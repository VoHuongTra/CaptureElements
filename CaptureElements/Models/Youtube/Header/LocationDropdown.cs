using CaptureElements.Models.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace CaptureElements.Models.Youtube.Header
{
    public class LocationDropdown : BaseElement
    {
        public Button BackBtn { get; set; }
        public List<Button> Locations { get; set; }
    }
}
