using System;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Umaro.Formatters;

namespace Umaro
{
    //TODO: Cleanup and refactor the messy code
    public partial class FormMain : Form
    {
        #region Fields

        //Fields related to preview window
        private AnimationInfo _lastAnimation;
        private long _ticks;
        private int _frameIndex;

        //TODO: Move fonts and colors to separate class to allow custom styling
        private readonly Font _overlayFont = new Font(FontFamily.GenericSansSerif, 10.0f);
        private readonly Pen _selectionPen = new Pen(new SolidBrush(Color.White))
            {
                DashStyle = System.Drawing.Drawing2D.DashStyle.Dot
            };

        #endregion

        #region Initialization
        //Form's constructor
        public FormMain()
        {
            InitializeComponent();
            MaximizedBounds = Screen.FromHandle(Handle).WorkingArea;
            headerMenuMain.Renderer = new CustomMenuRenderer();

            lvAnimations.SmallImageList = ColorGenerator.GenerateColorIcons();
            cntMain.Panel2MinSize = 200; //HACK: Bug workaround
        }
        #endregion

        #region Window control buttons
        private void btnWindowClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnWindowMinMax_Click(object sender, EventArgs e)
        {
            WindowState = WindowState == FormWindowState.Maximized ? FormWindowState.Normal : FormWindowState.Maximized;
        }

        private void btnWindowMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region Menu button handling
        //New
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            zbMain.Image = zbPreview.Image = zbMain.InitialImage = zbPreview.InitialImage = null;
            AnimationContainer.Instance.New();
            mShowDataFrom(AnimationContainer.Instance);
        }

        //Import
        private void loadImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mOpenFile(AnimationContainer.Instance, ofDiag, ImageFormatter.Instance);
        }

        private void loadXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mOpenFile(AnimationContainer.Instance, openXmlDlg, XMLFormatter.Instance);
        }

        private void plainTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mOpenFile(AnimationContainer.Instance, openTextDlg, PlainTextFormatter.Instance);
        }

        //Export
        private void exportXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mSaveFile(AnimationContainer.Instance, saveXmlDlg, XMLFormatter.Instance);
        }

        private void exportPlainTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mSaveFile(AnimationContainer.Instance, saveTextDialog, PlainTextFormatter.Instance);
        }

        //Exit
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        //About
        private void aboutUmaroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox.Instance.Show();
        }
        #endregion

        #region Animations tab

        private void btnAddAnim_Click(object sender, EventArgs e)
        {
            string animName = InputBox.Show("Enter new animation name:");
            if (string.IsNullOrEmpty(animName))
                return;

            if (AnimationContainer.Instance.Animations.ContainsKey(animName))
            {
                MessageBox.Show(@"Error: this animation already exists!");
                btnAddAnim_Click(sender, e);
            }
            else
            {
                AnimationContainer.Instance.Animations.Add(animName, new AnimationInfo(animName));
                ListViewItem newItem = lvAnimations.Items.Add(animName, lvAnimations.Items.Count);
                lvAnimations.SelectedIndices.Clear();
                newItem.Selected = true;
                mRefreshAnimIcons();
            }
        }

        private void btnRemoveAnim_Click(object sender, EventArgs e)
        {
            if (lvAnimations.SelectedIndices.Count > 0)
            {
                string animName = lvAnimations.SelectedItems[0].Text;
                lvAnimations.Items.Remove(lvAnimations.SelectedItems[0]);
                AnimationContainer.Instance.Animations.Remove(animName);
                _lastAnimation = null;
                zbPreview.Image = null;

                mRefreshAnimIcons();
            }
        }

        private void lvAnimations_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvAnimations.SelectedItems.Count > 0)
            {
                AnimationInfo anim = AnimationContainer.Instance.
                                                        Animations[lvAnimations.SelectedItems[0].Text];

                pgFrameInfo.SelectedObject = anim;
                _lastAnimation = anim;
                lblAnimName.Text = anim.Name;
                lvFrames.Items.Clear();

                _frameIndex = 0;
                _ticks = 0;

                for (int i = 0; i < anim.Frames.Count; i++)
                    lvFrames.Items.Add(string.Format("Frame #" + i.ToString(CultureInfo.InvariantCulture)));
            }
        }

        #endregion

        #region Frames tab

        private void btnAddFrame_Click(object sender, EventArgs e)
        {
            AnimationInfo anim = _lastAnimation;
            if (anim == null)
                return;

            int fWidth;
            int fHeight;

            bool success = int.TryParse(txtFrameWidth.Text, out fWidth) & int.TryParse(txtFrameHeight.Text, out fHeight);
            if (!success)
            {
                MessageBox.Show(@"Cannot create frame of defined size", @"Error", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            FrameInfo frame = new FrameInfo
                {
                    X = 0,
                    Y = 0,
                    Width = fWidth,
                    Height = fHeight,
                    Delay = 100
                };

            anim.Frames.Add(frame);

            lvFrames.Items.Clear();
            for (int i = 0; i < anim.Frames.Count; i++)
                lvFrames.Items.Add(string.Format("Frame #" + i.ToString(CultureInfo.InvariantCulture)));

            lvFrames.SelectedIndices.Clear();
            lvFrames.Items[lvFrames.Items.Count - 1].Selected = true;
            pgFrameInfo.SelectedObject = frame;
        }


        private void btnRemoveFrame_Click(object sender, EventArgs e)
        {
            if (lvFrames.SelectedItems.Count > 0)
            {
                _lastAnimation.Frames.RemoveAt(lvFrames.SelectedIndices[0]);
                lvFrames.Items.RemoveAt(lvFrames.Items.Count - 1);
            }
        }

        private void lvFrames_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvFrames.SelectedItems.Count > 0)
                if (_lastAnimation != null)
                    pgFrameInfo.SelectedObject = _lastAnimation.Frames[lvFrames.SelectedIndices[0]];
        }

        #endregion

        #region Misc handlers (property window, timer, canvas, etc.)

        private void pgFrameInfo_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            if (pgFrameInfo.SelectedObject != null)
                if (pgFrameInfo.SelectedObject.GetType() == typeof(AnimationInfo))
                {
                    AnimationInfo newAnim = (AnimationInfo)pgFrameInfo.SelectedObject;
                    string oldName = AnimationContainer.Instance.
                                                        Animations.FirstOrDefault(x => x.Value == newAnim).Key;

                    AnimationContainer.Instance.Animations.Remove(oldName);
                    AnimationContainer.Instance.Animations.Add(newAnim.Name, newAnim);
                    mShowDataFrom(AnimationContainer.Instance);
                }
        }

        private void zbMain_Paint(object sender, PaintEventArgs e)
        {
            if (zbMain.Image == null)
                return;

            if (AnimationContainer.Instance.Animations.Count > 0)
            {
                int scale = zbMain.ImageScale;
                Point origin = new Point((zbMain.Size.Width - zbMain.Image.Width) / 2,
                                         (zbMain.Size.Height - zbMain.Image.Height) / 2);

                //Draw the frame borders
                foreach (AnimationInfo anim in AnimationContainer.Instance.Animations.Values)
                {
                    int i = lvAnimations.FindItemWithText(anim.Name).Index;
                    for (int j = 0; j < anim.Frames.Count; j++)
                    {
                        e.Graphics.DrawRectangle(ColorGenerator.GetPen(i),
                                                 origin.X + scale * anim.Frames[j].X, origin.Y + scale * anim.Frames[j].Y,
                                                 scale * anim.Frames[j].Width, scale * anim.Frames[j].Height);
                        e.Graphics.DrawString("#" + j.ToString(CultureInfo.InvariantCulture),
                                                _overlayFont, ColorGenerator.GetBrush(i),
                                                origin.X + scale * anim.Frames[j].X, origin.Y + scale * anim.Frames[j].Y);
                    }
                }

                //If user selected a frame, draw it's border where the mouse is located
                if (pgFrameInfo.SelectedObject == null)
                    return;

                FrameInfo frame = pgFrameInfo.SelectedObject as FrameInfo;
                Point quantizedPos = mMapControlToLocal(zbMain.PointToClient(Cursor.Position));
                if (frame != null)
                    e.Graphics.DrawRectangle(_selectionPen,
                                             origin.X + quantizedPos.X * scale, origin.Y + quantizedPos.Y * scale,
                                             frame.Width * scale, frame.Height * scale);
            }
        }

        private void tmrRefresh_Tick(object sender, EventArgs e)
        {
            zbMain.Invalidate();
        }

        private void tmrPreview_Tick(object sender, EventArgs e)
        {
            if (_lastAnimation == null)
            {
                _frameIndex = 0;
                zbPreview.Image = zbPreview.InitialImage = null;
                return;
            }

            if (_lastAnimation.Frames.Count > 1)
            {
                _ticks += tmrPreview.Interval;
                if (_lastAnimation.Frames[_frameIndex].Delay < _ticks)
                {
                    _ticks = 0;
                    _frameIndex++;
                    if (_lastAnimation.Frames.Count - 1 < _frameIndex)
                        _frameIndex = 0;
                }
            }
            else
                _frameIndex = 0;

            mUpdateFrame();
        }

        private void zbMain_MouseDown(object sender, MouseEventArgs e)
        {
            if (pgFrameInfo.SelectedObject == null)
                return;

            FrameInfo frame = pgFrameInfo.SelectedObject as FrameInfo;
            if (frame != null)
            {
                if (zbMain.InitialImage == null)
                    return;
                frame.Location = mMapControlToLocal(e.Location);
            }
        }

        private void zbMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (pgFrameInfo.SelectedObject == null)
                return;
            if (pgFrameInfo.SelectedObject.GetType() == typeof(FrameInfo))
                zbMain.Invalidate();
        }

        #endregion

        //TODO: Find/implement a custom TabControl for this
        #region Tab management

        //Default TabControl is almost non-customizable
        //So I decided to toggle panels instead
        //Looks dirty, but works
        private void btnTabAnimations_Click(object sender, EventArgs e)
        {
            btnTabAnimations.BackColor = btnAddAnim.BackColor;
            btnTabFrames.BackColor = cntSidebar.BackColor;
            pnlAnimations.Visible = pnlAnimations.Enabled = true;
            pnlFrames.Visible = pnlFrames.Enabled = false;
            lvFrames.SelectedIndices.Clear();
            pgFrameInfo.SelectedObject = null;
        }

        //Same here
        private void btnTabFrames_Click(object sender, EventArgs e)
        {
            btnTabFrames.BackColor = btnAddAnim.BackColor;
            btnTabAnimations.BackColor = cntSidebar.BackColor;
            pnlAnimations.Visible = pnlAnimations.Enabled = false;
            pnlFrames.Visible = pnlFrames.Enabled = true;
            lvAnimations.SelectedIndices.Clear();
            pgFrameInfo.SelectedObject = null;
        }

        #endregion
    }
}