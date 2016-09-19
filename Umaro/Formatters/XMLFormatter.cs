using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Umaro.Formatters
{
    public class XMLFormatter : FileFormatter
    {
        #region Singleton initialization
        private static XMLFormatter instance = new XMLFormatter();
        public static XMLFormatter Instance
        {
            get { return instance; }
        }
        #endregion
        
        //TODO: Check if it's possible to rewrite this without losing performance
        public override void Write(string path, AnimationContainer data)
        {
            using (XmlTextWriter wr = new XmlTextWriter(path, Encoding.Unicode))
            {
                wr.Formatting = Formatting.Indented;
                wr.Indentation = 4;

                wr.WriteStartDocument();
                wr.WriteStartElement("Root");
                foreach (KeyValuePair<string, AnimationInfo> pair in data.Animations)
                {
                    wr.WriteStartElement("Animation");
                    wr.WriteElementString("Name", pair.Key);
                    wr.WriteStartElement("Frames");

                    int i = 0;
                    foreach (FrameInfo frame in pair.Value.Frames)
                    {
                        wr.WriteStartElement("Frame");
                        wr.WriteElementString("ID", i.ToString());
                        wr.WriteElementString("X", frame.X.ToString());
                        wr.WriteElementString("Y", frame.Y.ToString());
                        wr.WriteElementString("Width", frame.Width.ToString());
                        wr.WriteElementString("Height", frame.Height.ToString());
                        wr.WriteElementString("Delay", frame.Delay.ToString());
                        wr.WriteEndElement();
                        i++;
                    }

                    wr.WriteEndElement();
                    wr.WriteEndElement();
                }
                wr.WriteEndElement();
                wr.WriteEndDocument();
            }
        }

        public override void Read(string path, AnimationContainer target)
        {
            target.Animations.Clear();

            using (XmlTextReader rd = new XmlTextReader(path))
            {
                AnimationInfo curAnim = null;
                FrameInfo curFrame = null;
                while (rd.Read())
                {
                    if (rd.NodeType.Equals(XmlNodeType.Element))
                    {
                        switch (rd.LocalName)
                        {
                            case "Animation":
                                curAnim = new AnimationInfo();
                                break;
                            case "Name":
                                curAnim.Name = rd.ReadElementContentAsString(); break;
                            case "Frames":
                                curAnim.Frames = new List<FrameInfo>(); break;
                            case "Frame":
                                curFrame = new FrameInfo(); break;

                            case "ID":
                                curAnim.Frames.Insert(rd.ReadElementContentAsInt(), curFrame);
                                break;
                            case "X":
                                curFrame.X = rd.ReadElementContentAsInt(); break;
                            case "Y":
                                curFrame.Y = rd.ReadElementContentAsInt(); break;
                            case "Width":
                                curFrame.Width = rd.ReadElementContentAsInt(); break;
                            case "Height":
                                curFrame.Height = rd.ReadElementContentAsInt(); break;
                            case "Delay":
                                curFrame.Delay = rd.ReadElementContentAsInt(); break;
                        }
                    }
                    else if (rd.NodeType.Equals(XmlNodeType.EndElement))
                    {
                        switch (rd.LocalName)
                        {
                            case "Animation":
                                target.Animations.Add(curAnim.Name, curAnim); break;
                        }
                    }
                }
            }
        }
    }
}
