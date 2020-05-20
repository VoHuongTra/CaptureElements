using CaptureElements.Models.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace CaptureElements.Models.Google.Translate
{
    public class ListBoxLanguage: BaseElement
    {
        public TextBox SearchBox { get; set; }
        public Button Vietnamese { get; set; }
        public Button English { get; set; }
        public Button French { get; set; }
        public Button German { get; set; }
        public Button Korean { get; set; }
        public Button Mexico { get; set; }
        public Button Russian { get; set; }
        public Button Spanish { get; set; }
    }
}
