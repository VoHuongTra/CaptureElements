using CaptureElements.Models.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace CaptureElements.Models.Google.Search
{
    public class GoogleSearchResult :BaseElement
    {
        public SearchCategory SearchCategory { get; set; }
        public List<Button> SearchRelated { get; set; }
        public PageSearchForArticles PageSearchForArticles { get; set; }
        public PageSearchForVideos PageSearchForVideos { get; set; }
        public PageSearchForImage PageSearchForImage { get; set; }
        public Button NextPageButton { get; set; }
        public Button PreviousPageButton { get; set; }

        public CommonElement CommonElement { get; set; }
        public string CurrentUrl { get; set; }
    }
    public class SearchCategory : BaseElement
    {
        public Category CategoryAll { get; set; }
        public Category CategoryImages { get; set; }
        public Category CategoryVideos { get; set; }
        public Category CategoryNews { get; set; }
    }
    public class Category : BaseElement
    {
        public bool IsSelected { get; set; }
        public string Href { get; set; }
    }
}
