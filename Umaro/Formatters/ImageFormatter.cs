using System.Drawing;
using System.IO;

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

        public override void Read(string path, AnimationContainer target)
        {
            //Metadata is now loaded through PNGMetaFormatter
            using (FileStream stream = new FileStream(path, FileMode.Open, FileAccess.Read))
                target.Sprite = (Bitmap)Image.FromStream(stream);
        }
    }
}
