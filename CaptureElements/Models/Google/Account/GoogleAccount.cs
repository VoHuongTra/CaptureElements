using CaptureElements.Models.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace CaptureElements.Models.Google.Account
{
    public class GoogleAccount
    {
        public Navigation Navigation { get; set; }
        public Header Header { get; set; }

        public PageDataAndPersonalization PageDataAndPersonalization { get; set; }
        public PagePersonalInfo PagePersonalInfo { get; set; }
        public PageSercurity PageSecurity { get; set; }
    }
}
