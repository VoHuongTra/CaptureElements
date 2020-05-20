using CaptureElements.Models.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace CaptureElements.Models.Google.Translate
{
    public class GoogleTranslate : BaseElement
    {
        public Button DetectLanguage { get; set; }
        public Button SwapLanguage { get; set; }
        public Button ShowListBoxOnTransComponent { get; set; }
        public Button ShowListBoxOnResultComponent { get; set; }
        public TextBox TranslateTextbox { get; set; }
        public ListBoxLanguage ListBoxLanguage { get; set; }
        public Button ClearTextBtn { get; set; }
        public Button SuggestionBtn { get; set; }
        public Button HistoryBtn { get; set; }
        public Button GotItBtn { get; set; }
    }
}
