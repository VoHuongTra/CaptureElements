using CaptureElements.Models.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace CaptureElements.Models.Youtube.PageChannel
{
    public class VideoSoftDropdown : BaseElement
    {
        public bool IsShowed { get; set; }
        public CurrentSoftTypes CurrentSoftType { get; set; }
        public List<Button> SoftTypeBtns { get; set; }
    }

    public enum CurrentSoftTypes
    {
        Popular,
        Oldest,
        Newest
    }
}
