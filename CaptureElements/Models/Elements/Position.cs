using System;
using System.Collections.Generic;
using System.Text;

namespace CaptureElements.Models.Elements
{
    public class Position
    {
        public int Left { get; set; }
        public int Top { get; set; }
        public RelatedToWindow RelatedToWindow { get; set; }
    }
    public enum RelatedToWindow
    {
        Center = 0,
        Above = 1,
        Under = 2,
        Left = 3,
        Rights = 4
    }
}
