using CaptureElements.Models.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace CaptureElements.Models.Youtube.Header
{
    public class AccountDropdown : BaseElement
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public Button YourChannelBtn { get; set; }
        public Button YoutubeStudioBtn { get; set; }
        public Button SwitchAccountBtn { get; set; }
        public SwitchAccountDropdown SwitchAccountDropdown { get; set; }
        public Button SignOutBtn { get; set; }

        // language
        public Button LanguageBtn { get; set; }
        public LanguageDropdown LanguageDropdown { get; set; }

        // location
        public Button LocationBtn { get; set; }
        public LocationDropdown LocationDropdown { get; set; }


    }
}
