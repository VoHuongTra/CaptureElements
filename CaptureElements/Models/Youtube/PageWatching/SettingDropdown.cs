using CaptureElements.Models.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace CaptureElements.Models.Youtube.PageWatching
{
    public class SettingDropdown : BaseElement
    {
        public bool? IsShowed { get; set; }
        public Button QualityBtn { get; set; }
        public VideoQualities? CurrentQuality { get; set; }
        public bool? IsAutoQualityOn { get; set; }
        public List<Button> VideoQualityBtns { get; set; }
    }
    public enum VideoQualities
    {
        Auto,
        Q144p,
        Q240p,
        Q360p,
        Q480p,
        Q720p,
        Q1080p,
        Q1440p,
        Q2160p
    }
}
