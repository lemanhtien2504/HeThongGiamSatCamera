using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camera
{
    public class FrameRecievedEventArgs : EventArgs
    {
        public FrameRecievedEventArgs(Bitmap frame)
        {
            Frame = frame;
        }

        public Bitmap Frame { get; }
    }
}
