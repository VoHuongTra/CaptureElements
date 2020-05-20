using CaptureElements.Models.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace CaptureElements.Models.Google.Search
{
    public class PageSearchForImage :BaseElement
    {
        public List<ImageItem> ImageItems { get; set; }
        public List<Button> KeywordRelated { get; set; }
        public DetailImagePanel DetailImagePanel { get; set; }
    }
    public class ImageItem : BaseElement
    {
        public Button Image { get; set; }
        public string ItemUrl { get; set; }
    }
    public class DetailImagePanel : BaseElement
    {
        public Button CancelPanel { get; set; }
        public ImageItem MainImage { get; set; }
        public List<Button> ImageRelated { get; set; }
    }
}
