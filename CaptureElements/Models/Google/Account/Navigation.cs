using CaptureElements.Models.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace CaptureElements.Models.Google.Account
{
    public class Navigation : BaseElement
    {
        public NavigationStates? NavigationState { get; set; }
        public Button HomeBtn { get; set; }
        public Button PersonalInfoBtn { get; set; }
        public Button DataAndPersonalizationBtn { get; set; }
        public Button SecurityBtn { get; set; }
        public Button PeopleAndSharingBtn { get; set; }
        public Button PaymentsAndSubscriptionsBtn { get; set; }
    }

    public enum NavigationStates
    {
        Home,
        PersonalInfo,
        DataAndPersonalization,
        Security,
        PeopleAndSharing,
        PaymentsAndSubscriptions
    }
}
