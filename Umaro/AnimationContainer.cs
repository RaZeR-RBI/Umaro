using System.Collections.Generic;
#if SYS_DRAWING
using System.Drawing;
#endif

namespace Umaro
{
    public class AnimationContainer
    {
        //TODO: Add multiple document support
        #region Singleton initialization
        private static readonly AnimationContainer _instance = new AnimationContainer();
        public static AnimationContainer Instance
        {
            get { return _instance; }
        }
        #endregion

        #region Fields

#if SYS_DRAWING
        private Bitmap _image;
        public Bitmap Sprite
        {
            get { return _image; }
            set {_image = value; }
        }
#endif

        private Dictionary<string, AnimationInfo> _animations 
            = new Dictionary<string, AnimationInfo>();

        public Dictionary<string, AnimationInfo> Animations
        {
            get { return _animations; }
        }

        public AnimationInfo this[string key]
        {
            get { return _animations[key]; }
        }
        #endregion

        #region Methods()
        public void New()
        {
#if SYS_DRAWING
            _image = null;
#endif
            _animations = new Dictionary<string, AnimationInfo>();
        }
        #endregion
    }
}