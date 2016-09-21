using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Umaro
{
    /// <summary>
    /// Utility class for color set generation
    /// </summary>
    public static class ColorGenerator
    {
        static List<Color> _colors = new List<Color>();
        static readonly List<Pen> _colorPens = new List<Pen>();
        static readonly List<Brush> _colorBrushes = new List<Brush>();

        /// <summary>
        /// Returns a KnownColor by it's index
        /// </summary>
        /// <param name="index">Color index</param>
        /// <returns></returns>
        public static Color GetColor(int index)
        {
            if (_colors.Count == 0)
                mInitialize();
            return _colors[index];
        }

        public static Pen GetPen(int index)
        {
            if (_colors.Count == 0)
                mInitialize();
            return _colorPens[index];
        }

        public static Brush GetBrush(int index)
        {
            if (_colors.Count == 0)
                mInitialize();
            return _colorBrushes[index];
        }

        /// <summary>
        /// Generates a set of 14x14 different colored squares
        /// </summary>
        /// <returns></returns>
        public static ImageList GenerateColorIcons()
        {
            if (_colors.Count == 0)
                mInitialize();

            ImageList icons = new ImageList
            {
                ColorDepth = ColorDepth.Depth32Bit
            };

            foreach (Color clr in _colors)
            {
                Bitmap icon = new Bitmap(14, 14);
                using (Graphics g = Graphics.FromImage(icon))
                    g.FillRectangle(new SolidBrush(clr), 1, 1, 12, 12);

                icons.Images.Add(icon);
            }

            return icons;
        }

        #region Helper methods
        static void mInitialize()
        {
            _colors = mGetColors();
            foreach (Color clr in _colors)
            {
                _colorPens.Add(new Pen(clr));
                _colorBrushes.Add(new SolidBrush(clr));
            }
        }

        static List<Color> mGetColors()
        {
            List<Color> result = new List<Color>();
            List<string> allColorNames = Enum.GetNames(typeof(KnownColor)).OrderBy(
                kc => 1.0f - Color.FromName(kc).GetSaturation()).ToList();

            foreach (string clrName in allColorNames)
            {
                Color curClr = Color.FromName(clrName);
                if (!curClr.IsSystemColor)
                    if (curClr.R != curClr.G && curClr.G != curClr.B)
                        if ((0.299 * curClr.R + 0.587 * curClr.G + 0.114 * curClr.B) > 64
                            && (0.299 * curClr.R + 0.587 * curClr.G + 0.114 * curClr.B) < 215)
                            result.Add(curClr);
            }
            return result;
        }
        #endregion
    }
}
