using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Umaro.Formatters
{
    //TODO: Check for Mono compatibility (ATM it uses WPF PresentationCore.dll library)
    public class PNGMetaFormatter : FileFormatter
    {
        private const string metaKey = "/[0]tEXt/AnimData";

        private static readonly PNGMetaFormatter _instance = new PNGMetaFormatter();
        public static PNGMetaFormatter Instance
        {
            get { return _instance; }
        }

        public override void Read(string path, AnimationContainer target)
        {
            //Load the base image
            using (FileStream stream = new FileStream(path, FileMode.Open, FileAccess.Read))
                target.Sprite = (Bitmap)Image.FromStream(stream);

            //Now open the image for metadata reading
            Stream pngStream = new FileStream(path, FileMode.Open, FileAccess.ReadWrite, FileShare.None);
            PngBitmapDecoder pngDecoder = new PngBitmapDecoder(pngStream, BitmapCreateOptions.PreservePixelFormat,
                BitmapCacheOption.None);
            BitmapFrame pngFrame = pngDecoder.Frames[0];

            string meta = "";

            InPlaceBitmapMetadataWriter pngInplace = pngFrame.CreateInPlaceBitmapMetadataWriter();
            if (pngInplace != null)
            {
                object query = pngInplace.GetQuery(metaKey);
                if (query != null) meta = query.ToString();
            }

            if (!string.IsNullOrEmpty(meta))
            {
                string[] lines = meta.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                AnimationInfo curAnim = null;

                target.Animations.Clear();
                foreach (string line in lines)
                {
                    if (line.StartsWith("a "))
                    {
                        if (curAnim != null)
                            target.Animations.Add(curAnim.Name, curAnim);
                        curAnim = new AnimationInfo(line.Substring("a ".Length));
                    }
                    else if (line.StartsWith("f "))
                    {
                        string[] values = line.Substring("f ".Length).Split(' ');
                        if (curAnim != null)
                            curAnim.Frames.Add(new FrameInfo
                                {
                                    X = int.Parse(values[0]),
                                    Y = int.Parse(values[1]),
                                    Width = int.Parse(values[2]),
                                    Height = int.Parse(values[3]),
                                    Delay = int.Parse(values[4])
                                });
                    }
                }

                if (curAnim != null)
                    target.Animations.Add(curAnim.Name, curAnim);
            }
        }

        public override void Write(string path, AnimationContainer data)
        {
            //Write the animation data to string
            StringBuilder meta = new StringBuilder();

            foreach (AnimationInfo anim in data.Animations.Values)
            {
                meta.AppendLine("a " + anim.Name);
                foreach (FrameInfo frame in anim.Frames)
                    meta.AppendLine(string.Format("f {0} {1} {2} {3} {4}",
                                                  frame.X, frame.Y, frame.Width, frame.Height, frame.Delay));
            }

            //Set up the pipeline
            BitmapMetadata metadata = new BitmapMetadata("png");
            metadata.SetQuery(metaKey, meta.ToString());

            BitmapFrame bmpFrame = BitmapFrame.Create(mConvert(data.Sprite), null, metadata, null);

            var encoder = new PngBitmapEncoder();
            encoder.Frames.Clear();
            encoder.Frames.Add(bmpFrame);

            //Save the final PNG
            using (FileStream fs = new FileStream(path, FileMode.Create))
                encoder.Save(fs);
        }

        private BitmapSource mConvert(Bitmap bitmap)
        {
            var bitmapData = bitmap.LockBits(
                new Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.ReadOnly, bitmap.PixelFormat);

            var bitmapSource = BitmapSource.Create(
                bitmapData.Width, bitmapData.Height, 96, 96, PixelFormats.Bgra32, null,
                bitmapData.Scan0, bitmapData.Stride * bitmapData.Height, bitmapData.Stride);

            bitmap.UnlockBits(bitmapData);
            return bitmapSource;
        }
    }
}
