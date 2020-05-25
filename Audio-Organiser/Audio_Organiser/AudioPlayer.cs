using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Audio_Organiser
{
    class AudioPlayer
    {
        [DllImport("winmm.dll")]
        private static extern long mciSendString(string lpstrCommand, StringBuilder lpstrReturnString, int uReturnLength, int hwdCallBack);

        public void open(string File)
        {
            string command = "open \"" + File + "\" type mpegvideo alias MediaFile";
            mciSendString(command, null, 0, 0);
        }

        public void play()
        {
            string command = "play MediaFile";
            mciSendString(command, null, 0, 0);
        }
        public void pause()
        {
            string command = "pause MediaFile";
            mciSendString(command, null, 0, 0);
        }

        public void stop()
        {
            string command = "close MediaFile";
            mciSendString(command, null, 0, 0);
        }

        public void volume(int value)
        {
                mciSendString(string.Concat("setaudio MediaFile volume to ", value), null, 0, 0);
        }
    }
}
