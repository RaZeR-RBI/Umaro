using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Umaro.Formatters
{
    public class ImageFormatter : FileFormatter
    {
        #region Singleton initialization
        private static ImageFormatter instance = new ImageFormatter();
        public static ImageFormatter Instance
        {
            get { return instance; }
        }
        #endregion

        public override void Write(string path, AnimationContainer data)
        {
            //TODO: Add png metadata saving
        }

        public override void Read(string path, AnimationContainer target)
        {
            //TODO: Add png metadata loading
            //Currently only loads the base image
            target.Sprite = (Bitmap)Image.FromFile(path);
        }
    }
}
