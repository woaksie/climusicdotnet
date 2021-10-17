using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibVLCSharp.Shared;


namespace dotnetapp2.VLC
{
    public class Player
    {
        private MediaPlayer mp;
        private LibVLC _libVlc;

        public void Initialize()
        {
            Core.Initialize();
            _libVlc = new LibVLC("-I", "null");
            mp = new MediaPlayer(_libVlc);
        }

        public void HookupTimeEvents(EventHandler<MediaPlayerTimeChangedEventArgs> handler)
        {
            mp.TimeChanged += handler;
        }
    }
}
