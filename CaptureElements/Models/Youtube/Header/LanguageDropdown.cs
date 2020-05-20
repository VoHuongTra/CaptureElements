using CaptureElements.Models.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace CaptureElements.Models.Youtube.Header
{
    public class LanguageDropdown : BaseElement
    {
        public Button BackBtn { get; set; }
        public List<Button> Languages { get; set; }
    }
}
