using CaptureElements.Models.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace CaptureElements.Models.Youtube.Header
{
    public class SwitchAccountDropdown : BaseElement
    {
        public Button BackBtn { get; set; }
        public List<Button> Accounts { get; set; }
    }
}
