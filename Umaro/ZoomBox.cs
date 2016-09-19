﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Umaro
{
    internal class ZoomBox : PictureBox
    {
        public InterpolationMode InterpolationMode { get; set; }
        protected int _imageScale = 1;

        public int ImageScale
        {
            get { return _imageScale; }
        }

        private Label _scaleLabel;

        private const int grab = 16;
        private bool _resizable;
        public bool Resizable
        {
            get { return _resizable; }
            set { _resizable = ResizeRedraw = value; }
        }

        public new Image Image
        {
            get { return base.Image; }
            set
            {
                base.Image = InitialImage = value;
                if (_imageScale != 1)
                    SetImageScale(_imageScale);
            }
        }

        protected override void OnCreateControl()
        {
            string parentName = Name;
            Size parentSize = Size;

            base.OnCreateControl();

            Panel ctlPanel = new Panel()
                {
                    Name = parentName + "_ctlPanel",
                    Size = new Size(96, 24),
                    Anchor = AnchorStyles.Top | AnchorStyles.Right,
                    Location = new Point(parentSize.Width - 100, 0),
                    BorderStyle = BorderStyle.None,
                    BackColor = Color.Black
                };

            NoPadButton zoomOut = new NoPadButton()
                {
                    Name = parentName + "_zoomOut",
                    OwnerDrawText = Text = @"-",
                    Size = new Size(24, 24),
                    Padding = Padding.Empty,
                    FlatStyle = FlatStyle.Flat,
                    BackColor = Color.DimGray
                };

            zoomOut.GotFocus += delegate
                {
                    Focus();
                };

            zoomOut.Click += delegate
                {
                    if (_imageScale > 1)
                    {
                        _imageScale--;
                        SetImageScale(_imageScale);
                    }
                    else
                    {
                        base.Image = InitialImage;
                    }
                };

            NoPadButton zoomIn = new NoPadButton()
            {
                Name = parentName + "_zoomIn",
                OwnerDrawText = Text = @"+",
                Size = new Size(24, 24),
                Padding = Padding.Empty,
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.DimGray,
                Location = new Point(72, 0)
            };

            zoomIn.GotFocus += delegate
            {
                this.Focus();
            };

            zoomIn.Click += delegate
                {
                    if (_imageScale < 9)
                    {
                        _imageScale++;
                        SetImageScale(_imageScale);
                    }
                };

            _scaleLabel = new Label()
                {
                    AutoSize = false,
                    Text = @"100%",
                    Location = new Point(0, 1),
                    Size = new Size(96, 24),
                    TextAlign = ContentAlignment.MiddleCenter,
                    BorderStyle = BorderStyle.None,
                    BackColor = Color.FromArgb(25, 25, 25),
                    ForeColor = Color.Gray,
                    Font = new Font("Consolas", 8.0f, FontStyle.Bold)
                };

            ctlPanel.Controls.Add(_scaleLabel);
            ctlPanel.Controls.Add(zoomOut);
            ctlPanel.Controls.Add(zoomIn);
            zoomOut.BringToFront();
            zoomIn.BringToFront();

            Controls.Add(ctlPanel);
        }

        protected void SetImageScale(int scale)
        {
            _scaleLabel.Text = scale.ToString() + @"00%";
            base.Image = ResizeImage(InitialImage, scale);
            Refresh();
        }

        protected override void OnPaint(PaintEventArgs paintEventArgs)
        {
            paintEventArgs.Graphics.InterpolationMode = InterpolationMode;
            base.OnPaint(paintEventArgs);
            if (_resizable)
            {
                var rc = new Rectangle(this.ClientSize.Width - grab, this.ClientSize.Height - grab, grab, grab);
                ControlPaint.DrawSizeGrip(paintEventArgs.Graphics, this.BackColor, rc);
            }
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (_resizable)
                if (m.Msg == 0x84)
                {  // Trap WM_NCHITTEST
                    var pos = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (pos.X >= this.ClientSize.Width - grab && pos.Y >= this.ClientSize.Height - grab)
                        m.Result = new IntPtr(17);  // HT_BOTTOMRIGHT
                }
        }

        protected Image ResizeImage(Image src, int times)
        {
            if (src == null)
                return null;

            Bitmap result = new Bitmap(src.Width * times, src.Height * times);
            using (Graphics g = Graphics.FromImage(result))
            {
                g.CompositingQuality = CompositingQuality.HighSpeed;
                g.InterpolationMode = InterpolationMode.NearestNeighbor;
                g.SmoothingMode = SmoothingMode.None;
                g.PixelOffsetMode = PixelOffsetMode.Half;
                g.DrawImage(src, 0, 0, result.Width, result.Height);
            }
            return result;

        }

        public class NoPadButton : Button
        {
            private string ownerDrawText;
            public string OwnerDrawText
            {
                get { return ownerDrawText; }
                set { ownerDrawText = value; Invalidate(); }
            }

            protected override bool ShowFocusCues
            {
                get
                {
                    return false;
                }
            }

            protected override void OnPaint(PaintEventArgs e)
            {
                base.OnPaint(e);

                if (string.IsNullOrEmpty(Text) && !string.IsNullOrEmpty(ownerDrawText))
                {
                    StringFormat stringFormat = new StringFormat
                        {
                            Alignment = StringAlignment.Center,
                            LineAlignment = StringAlignment.Center
                        };

                    e.Graphics.DrawString(ownerDrawText, Font, new SolidBrush(ForeColor), ClientRectangle, stringFormat);
                }
            }
        }
    }
}
