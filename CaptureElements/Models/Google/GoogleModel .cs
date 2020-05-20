using CaptureElements.Models.Google.Account;
using CaptureElements.Models.Google.Search;
using CaptureElements.Models.Google.Translate;
using System;
using System.Collections.Generic;
using System.Text;

namespace CaptureElements.Models.Google
{
    public class GoogleModel
    {
        public GoogleAccount GoogleAccount { get; set; }
        public GoogleHome GoogleHome { get; set; }
        public GoogleSearchResult GoogleSearchResult { get; set; }
        public GoogleTranslate GoogleTranslate { get; set; }
    }
}
