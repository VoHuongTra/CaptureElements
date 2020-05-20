using CaptureElements.Models.Elements;
using CaptureElements.Models.Youtube.Commons;
using System;
using System.Collections.Generic;
using System.Text;

namespace CaptureElements.Models.Youtube.PageChannel
{
    public class PageChannel : BaseElement
    {
        public PageChannelModes? PageChannelMode { get; set; }
        public Channel Channel { get; set; }
        public bool? IsSubscribe { get; set; }
        public Button SubscribeBtn { get; set; }
        public Button SubscriptionNotificationBtn { get; set; }
        public UnSubscibeDropdown UnSubscibeDropdown { get; set; }
        public SubscriptionNotificationDropdown SubscriptionNotificationDropdown { get; set; }
        public VideoSoftDropdown VideoSoftDropdown { get; set; }
        public Button VideoSoftBtn { get; set; }
        public Button HomeBtn { get; set; }
        public Button VideoBtn { get; set; }
        public Button PlaylistBtn { get; set; }
        public Button ChannelBtn { get; set; }
        public List<Video> Videos { get; set; }
        public List<Playlist> Playlists { get; set; }
        public List<Channel> RelatedChannels { get; set; }
    }
    public enum PageChannelModes
    {
        Home,
        Video,
        Playlist,
        Community,
        Channels,
        About
    }

}
