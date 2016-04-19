using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Diagnostics;
using System.Windows.Media;

namespace RadioCART
{
    public class QueuePlayer
    {
        private MediaPlayer mCurrentSong;

        private bool mPlaying;

        public Queue<String> Songs
        {
            get;
            private set;
        }

        public QueuePlayer()
        {
            mPlaying = false;
            mCurrentSong = new MediaPlayer();
        }

        private void DelegateMethod(Object obj, EventArgs ea)
        {
            mCurrentSong.MediaEnded += DelegateMethod;
            if (Songs.Count != 0)
            {
                mCurrentSong.Open(new Uri(Songs.Dequeue()));
                mCurrentSong.Play();
            }

        }

        public bool StillPlaying()
        {
            return mPlaying;
        }

        public void StartPlaying(Queue<String> q)
        {
            mPlaying = true;
            Songs = q;
            PlayQueue();
        }

        public void StopPlaying()
        {
            if (mPlaying == true)
            {
                mCurrentSong.Stop();
                mPlaying = false;
            }
        }

        private void PlayQueue()
        {
            mCurrentSong.MediaEnded += DelegateMethod;
            if (Songs.Count != 0)
            {
                mCurrentSong.Open(new Uri(Songs.Dequeue()));
                mCurrentSong.Play();
            }
            mPlaying = false;
        }
    }
}
