using CaptureElements.Models.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace CaptureElements.Models.Youtube.PageSearch
{
    public class SearchRelated : BaseElement
    {
        public List<CardItem> CardItems { get; set; }
        public Button RightArrowBtn { get; set; }
        public Button LeftArrowBtn { get; set; }
    }
}
