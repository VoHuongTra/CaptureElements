using CaptureElements.Models.Elements;
using CaptureElements.Models.Youtube.Commons;
using System;
using System.Collections.Generic;
using System.Text;

namespace CaptureElements.Models.Youtube.PageSubscription
{
    public class SubscribedChannel : Channel
    {
        public bool IsSubscribed { get; set; }
        public Button SubscribeBtn { get; set; }
        public Button UnsubscribeBtn { get; set; }
        public Button CancelUnsubscribeBtn { get; set; }
        public Button Notification { get; set; }
        public BellDropdown BellDropdown { get; set; }
        public NotificationType? NotificationType { get; set; }
    }
    public enum NotificationType
    {
        All,
        Personalised,
        None
    }
}
