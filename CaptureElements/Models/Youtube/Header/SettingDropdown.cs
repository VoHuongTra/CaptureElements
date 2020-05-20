using CaptureElements.Models.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace CaptureElements.Models.Youtube.Header
{
    public class SettingDropdown : BaseElement
    {
        public Button LanguageBtn{ get; set; }
        public LanguageDropdown LanguageDropdown { get; set; }

        public Button LocationBtn { get; set; }
        public LocationDropdown LocationDropdown { get; set; }
    }
}
