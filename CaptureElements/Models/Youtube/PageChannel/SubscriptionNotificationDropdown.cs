
using CaptureElements.Models.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace CaptureElements.Models.Youtube.PageChannel
{
    public class SubscriptionNotificationDropdown : BaseElement
    {
        public bool IsShowed { get; set; }
        public NotificationTypes NotificationType { get; set; }
        public List<Button> SubscriptionNotificationOptions { get; set; }
    }
    public enum NotificationTypes
    {
        All,
        Personalised,
        None
    }
}
