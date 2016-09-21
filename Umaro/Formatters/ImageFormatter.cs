using System.Drawing;

namespace Umaro.Formatters
{
    public class ImageFormatter : FileFormatter
    {
        #region Singleton initialization
        private static readonly ImageFormatter instance = new ImageFormatter();
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
