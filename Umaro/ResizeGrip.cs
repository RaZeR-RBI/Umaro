using System;
using System.Drawing;
using System.Windows.Forms;

namespace Umaro
{
    public partial class ResizeGrip : UserControl
    {
        private bool _mouseDown;
        private Point _lastLocation;

        /// <summary>
        /// Gets or sets the control which will be resized by this grip
        /// </summary>
        public Control Target { get; set; }

        public ResizeGrip()
        {
            InitializeComponent();
        }

        private void ResizeGrip_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseDown = true;
            _lastLocation = e.Location;
        }

        private void ResizeGrip_MouseMove(object sender, MouseEventArgs e)
        {
            if (Target != null && _mouseDown)
                if (_lastLocation != e.Location)
                {
                    Size delta = new Size(e.Location.X - _lastLocation.X,
                                          e.Location.Y - _lastLocation.Y);
                    Target.Size += delta;
                    //_lastLocation = e.Location;
                    Target.PerformLayout();
                }

        }

        private void ResizeGrip_MouseUp(object sender, MouseEventArgs e)
        {
            _mouseDown = false;
        }

        private void ResizeGrip_MouseLeave(object sender, EventArgs e)
        {
            _mouseDown = false;
        }
    }
}
