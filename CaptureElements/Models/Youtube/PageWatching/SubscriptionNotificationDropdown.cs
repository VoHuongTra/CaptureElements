using CaptureElements.Models.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace CaptureElements.Models.Youtube.PageWatching
{
    public class SubscriptionNotificationDropdown : BaseElement
    {
        public bool? IsShowed { get; set; }
        public Notification_Types Notification_Type { get; set; }
        public List<Button> SubscriptionNotificationOptions { get; set; }
    }
    public enum Notification_Types
    {
        All,
        Persionalised,
        Non
    }
}
