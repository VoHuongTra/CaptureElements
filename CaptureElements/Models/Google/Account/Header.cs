using CaptureElements.Models.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace CaptureElements.Models.Google.Account
{
    public class Header : BaseElement
    {
        public Button HomeBtn { get; set; }
        public TextBox SearchBoxTxt { get; set; }
        // Google Apps Section
        public Button GoogleAppsDropdownBtn { get; set; }
        public GoogleAppsDropdown GoogleAppsDropdown { get; set; }
        // Google Account Section
        public Button GoogleAccountDropdownBtn { get; set; }
        public GoogleAccountDropdown GoogleAccountDropdown { get; set; }
    }

    public class GoogleAppsDropdown : BaseElement
    {
        List<Button> GoogleAppBtns { get; set; }
    }

    public class GoogleAccountDropdown : BaseElement
    {
        public string username { get; set; }
        public string name { get; set; }
    }
}
