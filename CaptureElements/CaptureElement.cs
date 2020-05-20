using CaptureElements.Models.Elements;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;

namespace CaptureElements
{
    public class CaptureElement
    {
        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        private static extern IntPtr GetWindowRect(IntPtr hWnd, ref Rect rect);

        [StructLayout(LayoutKind.Sequential)]
        private struct Rect
        {
            public int Left;
            public int Top;
            public int Right;
            public int Bottom;
        }

        public Bitmap Capture(BaseElement element)
        {
            Rectangle bounds;
            if(element.Size.Width != 0 && element.Size.Height != 0)
            {

                bounds = new Rectangle(element.Position.Left, element.Position.Top, element.Size.Width, element.Size.Height);

                var result = new Bitmap(bounds.Width, bounds.Height);

                using (var g = Graphics.FromImage(result))
                {
                    g.CopyFromScreen(new Point(bounds.Left, bounds.Top), System.Drawing.Point.Empty, bounds.Size);
                }
                return result;
            }
            return null;

        }
        public Image CaptureEle(BaseElement element)
        {
            return Capture(element);
        }
    }
}
