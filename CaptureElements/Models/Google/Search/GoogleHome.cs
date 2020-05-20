using CaptureElements.Models.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace CaptureElements.Models.Google.Search
{
    public class GoogleHome : BaseElement
    {
        public CommonElement CommonElement { get; set; }
        public List<Button> Languages { get; set; }
        public Button SearchBtn { get; set; }

        public Button GmailBtn { get; set; }
        public Button GooglePhotoBtn { get; set; }
        public Button GoogleImageCenter { get; set; }


    }

}
