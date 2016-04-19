using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;
using System.Windows.Media;
using System.Windows.Threading;

//TODO: Display file length and show remaining time numerically & visually

namespace RadioCART
{


    public partial class Line : UserControl
    {
        Form1 theForm;

        private MediaPlayer mPlayer;

        public MediaPlayer Player
        {
            get
            {
                return mPlayer;
            }
        }

        Boolean playable;

        int id;

        private String mSong;

        private DispatcherTimer mDt;

        public Line()
        {
            InitializeComponent();
            mPlayer = new MediaPlayer();
            mPlayer.MediaOpened += songLoaded;
            mDt = new DispatcherTimer();
            mDt.Interval = TimeSpan.FromMilliseconds(10);
            mDt.Tick += mDt_Tick;
            mDt.Start();
            playable = false;
        }

        void mDt_Tick(object sender, EventArgs e)
        {
            if (mPlayer.NaturalDuration.HasTimeSpan)
            {
                ElapsedTimeLabel.Text = (Math.Max(mPlayer.NaturalDuration.TimeSpan.TotalSeconds
                    - mPlayer.Position.TotalSeconds, 0)).ToString();
            }

            progressBar1.Value = Math.Min((int)mPlayer.Position.TotalMilliseconds, progressBar1.Maximum);
            //This improves the sync, somehow
            if (progressBar1.Value != 0)
            {
                if(progressBar1.Value-1 >= progressBar1.Minimum) progressBar1.Value--;
                if(progressBar1.Value+1 <= progressBar1.Maximum) progressBar1.Value++;
            }
        }

        public void SetUpLine(Form1 f, Int32 i){
            theForm = f;
            id = i;
            SetEjectLabel(i);
            
        }

        //this allows restarting still :(
        private void playButton_Click(object sender, EventArgs e)
        {
            if (playable == true)
            {
                if (checkBox1.CheckState == CheckState.Checked && !theForm.QueuePlayer.StillPlaying())
                {
                    theForm.QueuePlayer.StartPlaying(theForm.ReorderQueue(id));
                }
                else
                {
                    mPlayer.Open(new Uri(mSong));
                    mPlayer.Play();
                }
                
            }
        }

        

        private void stopButton_Click(object sender, EventArgs e)
        {
            if (playable == true)
            {
                if (checkBox1.CheckState == CheckState.Checked && theForm.QueuePlayer.StillPlaying())
                {
                    theForm.QueuePlayer.StopPlaying();
                }
                else
                {
                    mPlayer.Stop();
                }

            }
        }

        private void songLoaded(Object o, EventArgs ea)
        {
            double time = 0.0;
            theForm.Playlist.Add(mSong);
            if (mPlayer.NaturalDuration.HasTimeSpan)
            {
                time = mPlayer.NaturalDuration.TimeSpan.TotalSeconds;
            }
            TotalTimeLabel.Text = Math.Round(time, 3).ToString();
            playable = true;

            progressBar1.Minimum = 0;
            progressBar1.Maximum = (int)mPlayer.NaturalDuration.TimeSpan.TotalMilliseconds;
        }

        private void ejectButton_Click(object sender, EventArgs e)
        {
            progressBar1.DataBindings.Clear();
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //if new file is not in current playlist, proceed
                if (!theForm.Playlist.Contains(ofd.FileName))
                {
                    //if old file is in playlist, remove it
                    if (theForm.Playlist.Contains(fileName.Text))
                    {
                        theForm.Playlist.RemoveAt(theForm.Playlist.IndexOf(fileName.Text));
                    }

                    //Make this the new file
                    mSong = ofd.FileName;
                    fileName.Text = Path.GetFileName(mSong);
                    mPlayer.Open(new Uri(mSong));

                    //Uncheck the checkbox
                    checkBox1.Checked = false;
                }
                
                
            }
        }

        public void SetEjectLabel(int n)
        {
            ejectButton.Text = n.ToString();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            if (theForm.Playlist.IndexOf(mSong) >= 0)
            {
                theForm.Playlist.RemoveAt(theForm.Playlist.IndexOf(mSong));
            }
            
            fileName.Text = "Please load a file.";
            TotalTimeLabel.Text = null;
            ElapsedTimeLabel.Text = null;
            playable = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {
                theForm.Queue[id] = mSong;
            }
            else if (checkBox1.CheckState == CheckState.Unchecked)
            {
                theForm.Queue[id] = null;
            }
        }
    }
}
