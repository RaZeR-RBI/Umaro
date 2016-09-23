#if !DEBUG
using System;
#endif
using System.Windows.Forms;
using Umaro.Formatters;

namespace Umaro
{
    public partial class FormMain
    {
        private void mSaveFile(AnimationContainer data, SaveFileDialog dlg, FileFormatter exporter)
        {
#if !DEBUG
            try
            {
#endif
                if (dlg.ShowDialog() != DialogResult.Cancel)
                    exporter.Write(dlg.FileName, data);
#if !DEBUG
            }
            catch (Exception ex)
            {
                //Show the error message to user
                MessageBox.Show(ex.ToString(), @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
#endif
        }

        private void mOpenFile(AnimationContainer target, OpenFileDialog dlg, FileFormatter importer)
        {
#if !DEBUG
            try
            {
#endif
                if (dlg.ShowDialog() != DialogResult.Cancel)
                    importer.Read(dlg.FileName, target);

                mShowDataFrom(AnimationContainer.Instance);
#if !DEBUG
            }
            catch (Exception ex)
            {
                //Show the error message to user
                MessageBox.Show(ex.ToString(), @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
#endif
        }

        private void mShowDataFrom(AnimationContainer container)
        {
            _lastAnimation = null;
            pgFrameInfo.SelectedObject = null;
            zbMain.Image = container.Sprite;
            lvAnimations.Items.Clear();
            foreach (string anim in container.Animations.Keys)
                lvAnimations.Items.Add(anim);

            lvFrames.Items.Clear();
            mRefreshAnimIcons();
        }
    }
}
