using CaptureElements.Models.Elements;
using CaptureElements.Models.Youtube.Commons;
using System;
using System.Collections.Generic;
using System.Text;

namespace CaptureElements.Models.Youtube.PageWatching
{
    public class VideoPlayer : BaseElement
    {
        public PlayingStatus? PlayingStatus;
        public string FullScreenVideoTitle { get; set; }
        // Left Control
        public Button PlayBtn { get; set; }
        public Button NextBtn { get; set; }
        public Button PreviousBtn { get; set; }
        public SwitchButton MuteBtn { get; set; }

        // Right Control
        public SwitchButton SubtitleBtn { get; set; }
        public Button SettingBtn { get; set; }
        public Button MiniPlayerBtn { get; set; }
        public Button TheaterModeBtn { get; set; }
        public Button FullScreenBtn { get; set; }

        // Setting Popup
        public SettingDropdown SettingDropdown { get; set; }

        // Video Parameter
        public string CurrentTime { get; set; }
        public string VideoDuration { get; set; }

        // Ads Section
        public FullScreenAd FullScreenAd { get; set; }
        public CropScreenAd CropScreenAd { get; set; }

        // For EndScreen Videos
        public List<Video> EndScreenVideos { get; set; }
        public List<Video> WallScreenVideos { get; set; }
        public Channel EndScreenChannel { get; set; }

        // For ProgressBar
        public Button ProgressBar { get; set; }
    }

    public enum PlayingStatus
    {
        Playing,
        Paused,
        End
    }
}
