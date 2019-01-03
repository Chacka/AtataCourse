using Atata;

namespace PhpTravels.UITests.Components
{
    using _ = RoomsPage;

    [Url("/hotels/rooms")]
    public class RoomsPage : Page<_>
    {
        public ButtonDelegate<RoomEditPage, _> Add { get; private set; }

        [FindByClass("xcrud-list")]
        public Table<RoomRow, _> Rooms { get; private set; }

        public class RoomRow : TableRow<_>
        {
            public Text<_> Hotel { get; private set; }

            public Text<_> Price { get; private set; }
        }

    }
}

