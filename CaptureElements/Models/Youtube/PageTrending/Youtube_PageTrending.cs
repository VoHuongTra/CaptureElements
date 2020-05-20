using CaptureElements.Models.Elements;
using CaptureElements.Models.Youtube.Commons;
using System;
using System.Collections.Generic;
using System.Text;

namespace CaptureElements.Models.Youtube.PageTrending
{
    public class PageTrending : BaseElement
    {
        public PageTrendingModes PageTrendingMode { get; set; }
        public Button MusicBtn { get; set; }
        public Button GamingBtn { get; set; }
        public Button NewsBtn { get; set; }
        public Button MoviesBtn { get; set; }


        public List<Video> CommonTrendingVideos { get; set; }

        public List<Video> MusicTrendingVideos { get; set; }

        public List<Video> GamingTrendingVideos { get; set; }

        public List<Video> NewsTrendingVideos { get; set; }

        public List<Video> MoviesTrendingVideos { get; set; }
    }

    public enum PageTrendingModes
    {
        Home,
        Music,
        Gaming,
        News,
        Movies
    }
}
