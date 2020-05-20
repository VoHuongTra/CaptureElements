using CaptureElements.Models.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace CaptureElements.Models.Youtube.Header
{
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
