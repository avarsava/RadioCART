using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Diagnostics;

namespace RadioCART
{
    public class QueuePlayer
    {
        private SoundPlayer mCurrentSong;
        private Thread mTh;

        private bool mPlaying;

        public List<String> Songs
        {
            get;
            private set;
        }

        public QueuePlayer()
        {
            mPlaying = false;
            mCurrentSong = null;
        }

        public bool StillPlaying()
        {
            return mPlaying;
        }

        public void StartPlaying(List<String> q)
        {
            mPlaying = true;
            mTh = new Thread(PlayQueue);
            Songs = q;
            mTh.Start();
        }

        public void StopPlaying()
        {
            if (mTh != null && mPlaying == true)
            {
                mPlaying = false;
                mTh.Abort();
                mTh = null;
            }
        }

        private void PlayQueue()
        {
            foreach (String s in Songs)
            {
                mCurrentSong = new SoundPlayer(s);
                mCurrentSong.PlaySync();
            }
            mPlaying = false;
            mTh = null;
        }
    }
}
