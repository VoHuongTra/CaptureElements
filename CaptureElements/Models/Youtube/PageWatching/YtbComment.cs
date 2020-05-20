using CaptureElements.Models.Elements;
using CaptureElements.Models.Youtube.Commons;
using System;
using System.Collections.Generic;
using System.Text;

namespace CaptureElements.Models.Youtube.PageWatching
{
    public class YtbComment : BaseElement
    {
        public Channel Channel { get; set; }
        public string CommentContent { get; set; }
        public Button LikeBtn { get; set; }
        public Button DislikeBtn { get; set; }
        public bool? IsLiked { get; set; }
        public bool? IsDisliked { get; set; }
        public Button ReplyBtn { get; set; }
        public YtbCommentBox YtbCommentBox { get; set; }
    }
}
