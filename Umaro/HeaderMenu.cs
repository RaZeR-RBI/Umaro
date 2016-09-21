using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Umaro
{
    public partial class HeaderMenu : MenuStrip
    {
        protected bool mouseDown;
        protected Point lastLocation;

        /// <summary>
        /// The container which will be moved on mouse drag (like Form or Panel)
        /// </summary>
        public ContainerControl Target { get; set; }

        public HeaderMenu()
        {
            InitializeComponent();
        }

        public HeaderMenu(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            int width = 0;
            foreach (ToolStripItem item in DisplayedItems)
                width += item.Width;

            if (e.X > width)
            {
                mouseDown = true;
                lastLocation = e.Location;
            }

            base.OnMouseDown(e);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (Target != null)
                if (mouseDown)
                {
                    Target.Location = new Point((Target.Location.X - lastLocation.X) + e.X,
                                              (Target.Location.Y - lastLocation.Y) + e.Y);
                    Target.Update();
                }
            base.OnMouseMove(e);
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            mouseDown = false;
            base.OnMouseUp(e);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            mouseDown = false;
            base.OnMouseLeave(e);
        }
    }
}
