using CaptureElements.Models.Elements;
using CaptureElements.Models.Youtube.Commons;
using System;
using System.Collections.Generic;
using System.Text;

namespace CaptureElements.Models.Youtube.PageWatching
{
    public class Default_TheaterMode_PageWatching : BaseElement
    {
        public VideoPlayer VideoPlayer { get; set; }

        // Common Information
        public VideoWatchingTypes VideoWatchingType { get; set; }
        public string VideoTitle { get; set; }
        public string ViewCount { get; set; }
        public string UploadTime { get; set; }

        // Interact Information
        public Button LikeBtn { get; set; }
        public Button DislikeBtn { get; set; }
        public Button SubscribeBtn { get; set; }
        public UnSubscribeDropdown UnSubscribeDropdown { get; set; }
        public bool Isliked { get; set; }
        public bool IsDisLiked { get; set; }
        public bool? IsSubscribed { get; set; }
        public Button SubscriptionNotificationBtn { get; set; }
        public SubscriptionNotificationDropdown SubscriptionNotificationDropdown { get; set; }

        // Channel Information
        public Channel Channel { get; set; }

        // ALERT
        public Button ContinueWatchingBtn { get; set; }

        // Comment Section
        public bool? IsCommentAllowed { get; set; }
        public YtbCommentBox MainCommentBox { get; set; }
        public List<YtbComment> YtbComments { get; set; }
        public string CommentCount { get; set; }

        // For Live Video
        public string LiveViewsCount { get; set; }
        public bool? IsChatAllowed { get; set; }
        public bool? IsChatExpanded { get; set; }
        public Button ShowHideChatBtn { get; set; }
        public TextBox TextBox { get; set; }

        // RightSide Bar Chat Replay
        public bool? IsReplayExpanded { get; set; }
        public Button ShowHideChatReplayBtn { get; set; }


        // RightSide Ads
        public Button RightSideAd { get; set; }

        // RightSide Switch Button
        public SwitchButton AutoPlayBtn { get; set; }

        // RightSide Videos and Playlist
        public List<Video> RightSideVideos { get; set; }

        // RightSide Detailed Playlist
        public PlaylistBox PlaylistBox { get; set; }
    }
    public enum VideoWatchingTypes
    {
        Video,
        Playlist,
        Live
    }

}
