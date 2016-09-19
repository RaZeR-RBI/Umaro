using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Umaro.Formatters
{
    /// <summary>
    /// Base abstract class for XML and plain-text file reading/writing
    /// </summary>
    public abstract class FileFormatter
    {
        public virtual void Write(string path, AnimationContainer data)
        { }

        public virtual void Read(string path, AnimationContainer target)
        { }
    }
}
