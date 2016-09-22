using System.Collections.Generic;

#if SYS_DRAWING
using System.ComponentModel;
using System.Drawing;
#endif

namespace Umaro
{
    public class FrameInfo
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int Delay { get; set; }

#if SYS_DRAWING
        [Browsable(false)]
        public Point Location
        {
            get { return new Point(X, Y); }
            set
            {
                X = value.X;
                Y = value.Y;
            }
        }

        [Browsable(false)]
        public Point Size
        {
            get { return new Point(Width, Height); }
            set
            {
                Width = value.X;
                Height = value.Y;
            }
        }
#endif

        public override string ToString()
        {
            return string.Format("{0}x{1} {2} ms", Width, Height, Delay);
        }
    }

    public class AnimationInfo
    {
        public string Name { get; set; }
        public List<FrameInfo> Frames = new List<FrameInfo>();

        public AnimationInfo()
        { }

        public AnimationInfo(string name)
        {
            Name = name;
        }
    }
}
