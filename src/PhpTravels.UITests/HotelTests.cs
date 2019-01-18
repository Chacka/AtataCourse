using Atata;
using NUnit.Framework;
using PhpTravels.UITests.Components;
using System;
using System.Linq;

namespace PhpTravels.UITests
{
    public class HotelTests : UITestFixture
    {
        [Category("First")]
        [Test]
        public void Hotel_Add()
        {
            LoginAsAdmin();

            AddHotel(out string name).
               Hotels.Rows[x => x.Name == name].Should.BeVisible();
        }

        [Category("Second")]
        [Test]
        public void Hotel_Edit()
        {
            LoginAsAdmin();

            AddHotel(out string name).
                Hotels.Rows[x => x.Name == name].Should.BeVisible().
                Hotels.Rows[x => x.Name == name].Edit().
                Location.Set("Washington").
                Submit().
                Hotels.Rows[x => x.Name == name].Location.Should.Contain("Washington");
        }

        [Test]
        public void Hotel_Room_Add()
        {
            LoginAsAdmin();

            AddHotel(out string name).
                Hotels.Rows[x => x.Name == name].Should.BeVisible();
            Go.To<RoomsPage>().
                Add().
                    HotelName.Set(name).
                    RoomType.Set("Double or Twin Rooms").
                    RoomDescription.SetRandom().
                    Price.SetRandom(out int price).
                    Submit.Click();
            Go.To<RoomsPage>().
                Rooms.Rows.FirstOrDefault().Price.Should.Equal(price.ToString()).
                Rooms.Rows.FirstOrDefault().Hotel.Should.Equal(name);
        }

        private HotelsPage AddHotel(out string name)
        {
            return Go.To<HotelsPage>().
               Add.ClickAndGo().
                   HotelName.SetRandom(out name).
                   HotelDescription.SetRandom(out string description).
                   Location.Set("London").
                   HotelType.Set("Motel").
                   HotelStars.Set("3").
                   IsFeatured.Set("Yes").
                   From.Set(DateTime.Now).
                   To.Set(DateTime.Now + TimeSpan.FromDays(3)).
                   Submit();
        }
    }
}
