using CaptureElements.Models.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace CaptureElements.Models.Google.Search
{
    public class CommonElement
    {
        #region Common
        public AccountPanel AccountPanel { get; set; }
        public TextBox SearchBox { get; set; }
        public Button SignInBtn { get; set; }
        public Button AccountBtn { get; set; }
        public Button GoogleApplicationBtn { get; set; }
        public SearchSuggestDropdown SearchSuggestionDropdown { get; set; }
        #endregion
    }
    public class SearchSuggestDropdown : BaseElement
    {
        public List<SearchSuggestItem> SearchSuggests { get; set; }
    }
    public class SearchSuggestItem : BaseElement
    {
        public int Index { get; set; }
        public string Text { get; set; }
        public Button RemoveBtn { get; set; }
    }
}
