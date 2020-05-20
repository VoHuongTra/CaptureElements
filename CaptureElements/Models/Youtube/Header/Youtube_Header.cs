using CaptureElements.Models.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace CaptureElements.Models.Youtube.Header
{
    public class Header : BaseElement
    {
        public Button YoutubeIcon { get; set; }
        public TextBox SearchBox { get; set; }
        public Button SearchBtn { get; set; }
        public SearchSuggestDropdown SearchSuggestDropdown { get; set; }

        // for signed in
        public Button BellBtn { get; set; }
        public Button AccountIconBtn { get; set; }
        public AccountDropdown AccountDropdown { get; set; }

        // for not signed in
        public Button SettingBtn { get; set; }
        public SettingDropdown SettingDropdown { get; set; }
        public Button SignInBtn { get; set; }
    }
}
