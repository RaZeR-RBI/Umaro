using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace Umaro.Formatters
{
    public class PlainTextFormatter : FileFormatter
    {
        #region Singleton initialization
        private static PlainTextFormatter instance = new PlainTextFormatter();
        public static PlainTextFormatter Instance
        {
            get { return instance; }
        }
        #endregion

        public override void Write(string path, AnimationContainer data)
        {
            using (StreamWriter wr = new StreamWriter(path))
            {
                foreach (KeyValuePair<string, AnimationInfo> pair in data.Animations)
                {
                    wr.WriteLine("Animation {0}", pair.Key);

                    foreach (FrameInfo frame in pair.Value.Frames)
                        wr.WriteLine("Frame {0},{1},{2},{3} {4}",
                            frame.X, frame.Y, frame.Width, frame.Height, frame.Delay);

                    wr.WriteLine();
                }
            }
        }

        public override void Read(string path, AnimationContainer target)
        {
            target.Animations.Clear();

            using (StreamReader rd = new StreamReader(path))
            {
                AnimationInfo curAnim = null;
                FrameInfo curFrame = null;

                int i = 1;
                string line = rd.ReadLine();
                while (line != null)
                {
                    if (line.StartsWith("Animation "))
                    {
                        if (curAnim != null)
                        {
                            target.Animations.Add(curAnim.Name, curAnim);
                            curFrame = null;
                        }
                        curAnim = new AnimationInfo(line.Substring("Animation ".Length));
                    }
                    else if (line.StartsWith("Frame "))
                    {

                        if (curAnim == null)
                        {
                            //File is malformed, skip this frame
                            Trace.WriteLine(string.Format("{0}: Found a frame without animation " +
                                                          "at line {1}, skipping", path, i));
                            continue;
                        }

                        string[] values = line.Substring("Frame ".Length).Split(' ', ',');
                        try
                        {
                            curFrame = new FrameInfo()
                                {
                                    X = int.Parse(values[0]),
                                    Y = int.Parse(values[1]),
                                    Width = int.Parse(values[2]),
                                    Height = int.Parse(values[3]),
                                    Delay = int.Parse(values[4])
                                };

                            curAnim.Frames.Add(curFrame);
                        }
                        catch (Exception ex)
                        {
                            Trace.WriteLine(string.Format("{0}: Error reading line {1} - {2}",
                                path, i, ex));
                        }
                    }

                    line = rd.ReadLine();
                    i++;
                }
            }
        }
    }
}
