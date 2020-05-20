using CaptureElements.Models.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace CaptureElements.Models.Youtube.Guide
{
    public class Guide : BaseElement
    {
        public Button CollapseBtn { get; set; }
        public GuideDisplayState DisplayState { get; set; }

        public Button HomeBtn { get; set; }
        public Button TrendingBtn { get; set; }
        public Button SubscriptionBtn { get; set; }

        public Button LibraryBtn { get; set; }
        public Button HistoryBtn { get; set; }
        public Button YourVideoBtn { get; set; }
        public Button WatchLaterBtn { get; set; }
        public Button LikedVideoBtn { get; set; }
        public Button ShowMoreLibraryBtn { get; set; }
        public Button ShowLessLibraryBtn { get; set; }
        public bool LibraryExpanded { get; set; }

        public List<Subscription> Subscriptions { get; set; }
        public Button ShowMoreSubscriptionBtn { get; set; }
        public Button ShowLessSubscriptionBtn { get; set; }
        public bool SubscriptionExpanded { get; set; }
    }

    public enum GuideDisplayState
    {
        Open,
        Mini,
        Hidden
    }
}
