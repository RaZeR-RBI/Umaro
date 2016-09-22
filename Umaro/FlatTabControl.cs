using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Umaro
{
    //NOTE: Any changes to properties requires project rebuild (the forms designer will not update them without rebuild)
    //This probably will be fixed later

    public partial class FlatTabControl : TabControl
    {
        private Color backColor = SystemColors.Control;
        private Brush backBrush = new SolidBrush(SystemColors.Control);
        /// <summary>
        /// Gets or sets the background color of this TabControl
        /// </summary>
        public Color BackgroundColor
        {
            get { return backColor; }
            set
            {
                backColor = value;
                backBrush = new SolidBrush(backColor);
            }
        }

        private readonly List<SolidBrush> tabBackBrushes = new List<SolidBrush>();
        private readonly List<SolidBrush> tabForeBrushes = new List<SolidBrush>();


        private Color tabBorderColor = SystemColors.ButtonShadow;
        private Pen tabBorderPen = new Pen(SystemColors.ButtonShadow);
        /// <summary>
        /// Gets or sets the border color of the selected tab
        /// </summary>
        public Color TabBorderColor
        {
            get { return tabBorderColor; }
            set
            {
                tabBorderColor = value;
                tabBorderPen = new Pen(tabBorderColor);
            }
        }

        public FlatTabControl()
        {
            InitializeComponent();
            SetStyle(ControlStyles.AllPaintingInWmPaint |
                ControlStyles.DoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.UserPaint, true);
            mUpdateTabBrushes();
        }

        public FlatTabControl(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
            SetStyle(ControlStyles.AllPaintingInWmPaint |
                ControlStyles.DoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.UserPaint, true);
            mUpdateTabBrushes();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            //Fill the control background
            e.Graphics.FillRectangle(backBrush, e.ClipRectangle);

            if (tabBackBrushes.Count == 0 & TabPages.Count > 0)
                mUpdateTabBrushes();

            //Draw each tab header
            for (int i = 0; i < TabPages.Count; i++)
            {
                Rectangle tabRect = GetTabRect(i);
                TabPage page = TabPages[i];

                //Fill the tab header background
                e.Graphics.FillRectangle(tabBackBrushes[i], tabRect);

                tabRect.Inflate(-1, 0);
                tabRect.Height--;

                //Draw the border around selected tab header
                if (SelectedIndex == i)
                    e.Graphics.DrawRectangle(tabBorderPen, tabRect);

                //We have an icon specified, draw it
                if (page.ImageIndex != -1)
                    if (ImageList != null)
                    {
                        tabRect.X++;
                        e.Graphics.DrawImage(ImageList.Images[page.ImageIndex], tabRect.X + 2, tabRect.Y + 2);
                        tabRect.X += ImageList.Images[page.ImageIndex].Width;
                        tabRect.Width -= ImageList.Images[page.ImageIndex].Width;
                    }

                //Draw the tab name
                Rectangle paddedTextArea = tabRect;
                paddedTextArea.Offset(1, 0);
                TextRenderer.DrawText(e.Graphics, page.Text, Font, paddedTextArea, page.ForeColor);
            }
        }

        private void mUpdateTabBrushes()
        {
            tabBackBrushes.Clear();
            tabForeBrushes.Clear();

            if (TabPages.Count == 0)
                return;

            foreach (TabPage page in TabPages)
            {
                tabBackBrushes.Add(new SolidBrush(page.BackColor));
                tabForeBrushes.Add(new SolidBrush(page.ForeColor));
            }
        }
    }
}