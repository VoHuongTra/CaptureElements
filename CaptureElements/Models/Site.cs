using System;
using System.Collections.Generic;
using System.Text;

namespace CaptureElements.Models
{
    public class Site
    {
        public TabInfo TabInfo { get; set; }
        public SiteType SiteType { get; set; }
        public LoadingStatus LoadingStatus { get; set; }
        public object SiteModel { get; set; }
    }

    public class TabInfo
    {
        public int TabId { get; set; }
        public int TabIndex { get; set; }
        public bool IsTabActive { get; set; }
        public bool IsTabZoomed { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }

        public int WindowId { get; set; }
        public bool IsWindowActive { get; set; }

        public int InnerWidth { get; set; }
        public int InnerHeight { get; set; }
        public int OuterWidth { get; set; }
        public int OuterHeight { get; set; }
    }

    public enum SiteType
    {
        Unknown = 0,
        Youtube = 1,
        Google = 2,
    }

    public enum LoadingStatus
    {
        Loading,
        Complete
    }
}
