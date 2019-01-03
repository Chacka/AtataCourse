using Atata;

namespace PhpTravels.UITests.Components
{
    using _ = HotelEditPage;

    public class HotelEditPage : Page<_>
    {
        [FindByName(TermCase.LowerMerged)]
        [RandomizeStringSettings("AT Hotel {0}")]
        public TextInput<_> HotelName { get; private set; }

        public RichTextEditor<_> HotelDescription { get; private set; }

        [FindById("s2id_searching")]
        public AutoCompleteSelect<_> Location { get; private set; }

        public ButtonDelegate<HotelsPage, _> Submit { get; private set; }

        [FindByName(TermCase.LowerMerged)]
        public Select<_> HotelType { get; set; }

        [FindByName(TermCase.LowerMerged)]
        public Select<_> HotelStars { get; set; }

        [FindByName(TermCase.LowerMerged)]
        public Select<_> IsFeatured { get; set; }

        [FindByPlaceholder(TermCase.None)]
        public DateInput<_> From { get; set; }

        [FindByPlaceholder(TermCase.None)]
        public DateInput<_> To { get; set; }
    }
}