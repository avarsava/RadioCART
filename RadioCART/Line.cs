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

//TODO: Display file length and show remaining time numerically & visually

namespace RadioCART
{


    public partial class Line : UserControl
    {
        Form1 theForm;

        SoundPlayer player;

        Boolean playable;

        int id;


        public Line()
        {
            InitializeComponent();
            player = new SoundPlayer();
            playable = false;
        }

        public SoundPlayer getPlayer()
        {
            return player;
        }

        public void SetUpLine(Form1 f, Int32 i){
            theForm = f;
            id = i;
            SetEjectLabel(i);
            
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            if (playable == true && player.IsLoadCompleted)
            {
                if (checkBox1.CheckState == CheckState.Checked && !theForm.QueuePlayer.StillPlaying())
                {
                    theForm.QueuePlayer.StartPlaying(theForm.ReorderQueue(id));
                }
                else
                {
                    player.Play();
                }
                
            }
        }

        

        private void stopButton_Click(object sender, EventArgs e)
        {
            if (playable == true && player.IsLoadCompleted)
            {
                if (checkBox1.CheckState == CheckState.Checked && theForm.QueuePlayer.StillPlaying())
                {
                    theForm.QueuePlayer.StopPlaying();
                }
                else
                {
                    player.Stop();
                }

            }
        }

        private void ejectButton_Click(object sender, EventArgs e)
        {
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
                    fileName.Text = Path.GetFileName(ofd.FileName);
                    player.SoundLocation = ofd.FileName;
                    player.Load();
                    theForm.Playlist.Add(player.SoundLocation);
                    playable = true;
                }
                
                
            }
        }

        public void SetEjectLabel(int n)
        {
            ejectButton.Text = n.ToString();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            if (theForm.Playlist.IndexOf(player.SoundLocation) >= 0)
            {
                theForm.Playlist.RemoveAt(theForm.Playlist.IndexOf(player.SoundLocation));
            }
            
            fileName.Text = "Please load a file.";
            playable = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {
                theForm.Queue[id] = player.SoundLocation;
            }
            else if (checkBox1.CheckState == CheckState.Unchecked)
            {
                theForm.Queue[id] = null;
            }
        }
    }
}
