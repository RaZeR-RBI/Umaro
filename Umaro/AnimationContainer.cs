using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Umaro
{
    public class AnimationContainer
    {
        //TODO: Add multiple document support
        #region Singleton initialization
        private static AnimationContainer _instance = new AnimationContainer();
        public static AnimationContainer Instance
        {
            get { return _instance; }
        }
        #endregion

        #region Fields
        private Bitmap _image;
        public Bitmap Sprite
        {
            get { return _image; }
            set {_image = value; }
        }

        private Dictionary<string, AnimationInfo> _animations 
            = new Dictionary<string, AnimationInfo>();

        public Dictionary<string, AnimationInfo> Animations
        {
            get { return _animations; }
        }
        #endregion

        #region Methods()
        public void New()
        {
            _image = null;
            _animations = new Dictionary<string, AnimationInfo>();
        }
        #endregion
    }
}