using CaptureElements.Models.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace CaptureElements.Models.Youtube.PageHome
{
    public class ReportDropdown : BaseElement
    {
        public Button Report { get; set; }
        public Button NotInterested { get; set; }
        public Button DontRecommend { get; set; }
    }
}
