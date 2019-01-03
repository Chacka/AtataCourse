using Atata;

namespace PhpTravels.UITests.Components
{
    using _ = RoomEditPage;

    public class RoomEditPage : Page<_>
    {
        [FindById("s2id_autogen1")]
        public AutoCompleteSelect<_> RoomType { get; private set; }

        [FindById("s2id_autogen3")]
        public AutoCompleteSelect<_> HotelName { get; private set; }

        [FindById("cke_roomdesc")]
        public RichTextEditor<_> RoomDescription { get; private set; }

        [FindByPlaceholder(TermCase.None)]
        [RandomizeNumberSettings(min: 2000, max: 10000)]
        public NumberInput<_> Price { get; private set; }

        public Button<_> Submit { get; private set; }
    }
}