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

        private Line mCurrentLine;

        private bool mPlaying;

        public Queue<Line> Songs
        {
            get;
            private set;
        }

        public QueuePlayer()
        {
            mPlaying = false;
            mCurrentSong = new MediaPlayer();
            mCurrentLine = new Line();
        }

        private void DelegateMethod(Object obj, EventArgs ea)
        {
            if (Songs.Count != 0)
            {
                mCurrentLine = Songs.Dequeue();
                mCurrentLine.Player.MediaEnded += DelegateMethod;
                mCurrentLine.Player.Play();
            }

        }

        public bool StillPlaying()
        {
            return mPlaying;
        }

        public void StartPlaying(Queue<Line> q)
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
            
            if (Songs.Count != 0)
            {
                mCurrentLine = Songs.Dequeue();
                mCurrentLine.Player.MediaEnded += DelegateMethod;
                mCurrentLine.Player.Play();
            }
            mPlaying = false;
        }
    }
}
