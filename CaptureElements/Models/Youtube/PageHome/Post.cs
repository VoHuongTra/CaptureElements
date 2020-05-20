using CaptureElements.Models.Elements;
using CaptureElements.Models.Youtube.Commons;
using System;
using System.Collections.Generic;
using System.Text;

namespace CaptureElements.Models.Youtube.PageHome
{
    public class Post : BaseElement
    {
        public Channel Channel { get; set; }
        public string PostContent { get; set; }
        public string PostUrl { get; set; }
        public string UploadTime { get; set; }
        public string LikeCount { get; set; }
        public string CommentCount { get; set; }
        public Button LikeBtn { get; set; }
        public Button DislikeBtn { get; set; }
        public Button CommentBtn { get; set; }
        public Button ReportBtn { get; set; }
        public ReportDropdown ReportDropdown { get; set; }
        public bool IsLiked { get; set; }
        public bool IsDisliked { get; set; }



    }
}
