using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Umaro
{
    public partial class FormMain
    {
        private Point mMapControlToLocal(Point location)
        {
            Point imageOrigin = new Point((zbMain.Size.Width - zbMain.Image.Width) / 2,
                                     (zbMain.Size.Height - zbMain.Image.Height) / 2);

            //Move the selected frame origin to cursor
            return new Point((location.X - imageOrigin.X) / zbMain.ImageScale,
            (location.Y - imageOrigin.Y) / zbMain.ImageScale);
        }

        private void mRefreshAnimIcons()
        {
            int i = 0;
            foreach (ListViewItem item in lvAnimations.Items)
                item.ImageIndex = i++;
        }

        private void mUpdateFrame()
        {
            if (zbMain.InitialImage == null)
                return;

            if (_lastAnimation == null)
                return;

            FrameInfo frame = _lastAnimation.Frames[_frameIndex];
            Bitmap bm = new Bitmap(frame.Width, frame.Height);
            Rectangle bounds = new Rectangle(frame.X, frame.Y, frame.Width, frame.Height);

            using (Graphics g = Graphics.FromImage(bm))
                g.DrawImage(zbMain.InitialImage, new Rectangle(0, 0, frame.Width, frame.Height),
                    bounds, GraphicsUnit.Pixel);

            zbPreview.Image = bm;
        }

        private class CustomMenuRenderer : ToolStripProfessionalRenderer
        {
            //TODO: Move the colors and fonts to separate class to allow custom styling
            private readonly Brush back = new SolidBrush(Color.FromArgb(52, 52, 52));
            private readonly Pen border = new Pen(new SolidBrush(Color.FromArgb(25, 25, 25)));

            //Paint the menu item's background with custom color
            protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
            {
                Rectangle rc = new Rectangle(Point.Empty, e.Item.Size);
                e.Graphics.FillRectangle(back, rc);
                if (e.Item.Selected)
                    e.Graphics.DrawRectangle(border, 0, 0, rc.Width - 1, rc.Height - 1);
            }

            protected override void InitializeItem(ToolStripItem item)
            {
                base.InitializeItem(item);
                item.ForeColor = Color.Gray;

                ToolStripMenuItem menuItem = item as ToolStripMenuItem;
                if (menuItem != null) //This item is a drop-down menu
                    foreach (ToolStripMenuItem subItem in mGetItems(menuItem))
                        subItem.ForeColor = Color.Gray;
            }

            private IEnumerable<ToolStripMenuItem> mGetItems(ToolStripMenuItem item)
            {
                foreach (ToolStripMenuItem dropDownItem in item.DropDownItems)
                {
                    if (dropDownItem.HasDropDownItems)
                        foreach (ToolStripMenuItem subItem in mGetItems(dropDownItem))
                            yield return subItem;
                    yield return dropDownItem;
                }
            }
        }
    }
}