using CaptureElements.Models.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace CaptureElements.Models.Google.Search
{
    public class PageSearchForArticles :BaseElement
    {
        public List<Article> Articles { get; set; }
    }
    public class Article : BaseElement
    {
        public string Title { get; set; }
        public string ArticleUrl { get; set; }
    }
}
