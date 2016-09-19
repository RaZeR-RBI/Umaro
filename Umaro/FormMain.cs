using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Umaro.Formatters;

namespace Umaro
{
    //TODO: Cleanup and refactor the messy code
    public partial class FormMain : Form
    {
        #region Fields

        //Fields related to preview window
        private AnimationInfo _lastAnimation = null;
        private long _ticks = 0;
        private int _frameIndex = 0;

        //TODO: Move fonts and colors to separate class to allow custom styling
        private Font _overlayFont = new Font(FontFamily.GenericSansSerif, 10.0f);

        private Pen _selectionPen = new Pen(new SolidBrush(Color.White))
            {
                DashStyle = System.Drawing.Drawing2D.DashStyle.Dot
            };

        #endregion

        #region Initialization

        //Form's constructor
        public FormMain()
        {
            InitializeComponent();

            //TODO: Move these 2 lines to custom menu control
            MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            menu.Renderer = new CustomMenuRenderer();

            lvAnimations.SmallImageList = ColorGenerator.GenerateColorIcons();
            cntMain.Panel2MinSize = 200; //HACK: Bug workaround
        }

        #endregion

        //TODO: Move window drag handling and control buttons to separate custom control

        #region Window drag handling

        private bool mouseDown;
        private Point lastLocation;

        private void menu_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.X < 100)
                return; //Don't drag if clicked on menu buttons

            mouseDown = true;
            lastLocation = e.Location;
        }

        private void menu_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X,
                                          (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void menu_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void menu_MouseLeave(object sender, EventArgs e)
        {
            mouseDown = false;
        }

        #endregion

        #region Window control buttons

        private void btnWindowClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnWindowMinMax_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Normal;
            else
                WindowState = FormWindowState.Maximized;
        }

        private void btnWindowMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        #endregion

        #region Menu button handling

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            zbMain.Image = zbPreview.Image = zbMain.InitialImage = zbPreview.InitialImage = null;
            _lastAnimation = null;
            _ticks = _frameIndex = 0;
            lvAnimations.Items.Clear();
            lvFrames.Items.Clear();
            pgFrameInfo.SelectedObject = null;
            AnimationContainer.Instance.New();
        }

        private void loadImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mOpenFile(AnimationContainer.Instance, ofDiag, ImageFormatter.Instance);
            zbMain.Image = AnimationContainer.Instance.Sprite;
        }

        private void loadXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mOpenFile(AnimationContainer.Instance, openXmlDlg, XMLFormatter.Instance);
            lvAnimations.Items.Clear();
            foreach (string anim in AnimationContainer.Instance.Animations.Keys)
                lvAnimations.Items.Add(anim);

            mRefreshAnimIcons();
        }

        private void exportXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mSaveFile(AnimationContainer.Instance, saveXmlDlg, XMLFormatter.Instance);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutUmaroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox.Instance.Show();
        }

        private void plainTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mSaveFile(AnimationContainer.Instance, saveTextDialog, PlainTextFormatter.Instance);
        }

        private void plainTextToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            mOpenFile(AnimationContainer.Instance, openTextDlg, PlainTextFormatter.Instance);
            lvAnimations.Items.Clear();
            foreach (string anim in AnimationContainer.Instance.Animations.Keys)
                lvAnimations.Items.Add(anim);

            mRefreshAnimIcons();
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
                    lvFrames.Items.Add(string.Format("Frame #" + i.ToString()));
            }
        }

        #endregion

        #region Frames tab

        private void btnAddFrame_Click(object sender, EventArgs e)
        {
            AnimationInfo anim = _lastAnimation;
            if (anim == null)
                return;

            int fWidth = 16;
            int fHeight = 16;

            int.TryParse(txtFrameWidth.Text, out fWidth);
            int.TryParse(txtFrameHeight.Text, out fHeight);

            FrameInfo frame = new FrameInfo()
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
                lvFrames.Items.Add(string.Format("Frame #" + i.ToString()));

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
            {
                if (pgFrameInfo.SelectedObject.GetType() == typeof (AnimationInfo))
                {
                    AnimationInfo newAnim = (AnimationInfo) pgFrameInfo.SelectedObject;
                    string oldName = AnimationContainer.Instance.
                                                        Animations.FirstOrDefault(x => x.Value == newAnim).Key;

                    lvAnimations.Items.Remove(FindItem(lvAnimations, oldName));
                    AnimationContainer.Instance.Animations.Remove(oldName);

                    lvAnimations.Items.Add(newAnim.Name, 0);
                    AnimationContainer.Instance.Animations.Add(newAnim.Name, newAnim);

                    mRefreshAnimIcons();
                }
            }
        }

        private void zbMain_Paint(object sender, PaintEventArgs e)
        {
            if (zbMain.Image == null)
                return;

            if (AnimationContainer.Instance.Animations.Count > 0)
            {
                int scale = zbMain.ImageScale;
                Point origin = new Point((zbMain.Size.Width - zbMain.Image.Width)/2,
                                         (zbMain.Size.Height - zbMain.Image.Height)/2);

                //Draw the frame borders
                int i = 0;
                foreach (AnimationInfo anim in AnimationContainer.Instance.Animations.Values)
                {
                    i = lvAnimations.FindItemWithText(anim.Name).Index;
                    for (int j = 0; j < anim.Frames.Count; j++)
                    {
                        e.Graphics.DrawRectangle(ColorGenerator.GetPen(i),
                                                 origin.X + scale*anim.Frames[j].X,
                                                 origin.Y + scale*anim.Frames[j].Y,
                                                 scale*anim.Frames[j].Width,
                                                 scale*anim.Frames[j].Height);

                        e.Graphics.DrawString("#" + j.ToString(), _overlayFont,
                                              ColorGenerator.GetBrush(i),
                                              origin.X + scale*anim.Frames[j].X,
                                              origin.Y + scale*anim.Frames[j].Y);
                    }
                }

                //If user selected a frame, draw it's border where the mouse is located
                if (pgFrameInfo.SelectedObject == null)
                    return;

                FrameInfo frame = pgFrameInfo.SelectedObject as FrameInfo;
                Point quantizedPos = mMapControlToLocal(zbMain.PointToClient(Cursor.Position));
                if (frame != null)
                    e.Graphics.DrawRectangle(_selectionPen,
                                             origin.X + quantizedPos.X*scale,
                                             origin.Y + quantizedPos.Y*scale,
                                             frame.Width*scale,
                                             frame.Height*scale);
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

            if (pgFrameInfo.SelectedObject.GetType() == typeof (FrameInfo))
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