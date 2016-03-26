using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioCART
{
    public partial class Form1 : Form
    {
        private List<String> mPlaylist;

        public List<String> Playlist
        {
            get
            {
                return mPlaylist;
            }
            set
            {
                mPlaylist = value;
            }
        }

        private string[] mQueue;

        public string[] Queue
        {
            get
            {
                return mQueue;
            }
            set
            {
                mQueue = value;
            }
        }

        private SoundPlayer player;


        public Form1()
        {
            InitializeComponent();
            mPlaylist = new List<String>();
            mQueue = new string[5]; //strings are nullable btw 
            player = new SoundPlayer();
            addControls();
        }

        public void PlayQueue(int i)
        {
            int startingid = i;

            while (true)
            {
                if (mQueue[i] != null)
                {
                    player.SoundLocation = mQueue[i];
                    player.PlaySync();
                }
                
                i++;
                if (i == mQueue.Length)
                {
                    i = 0;
                }
                if (i == startingid)
                {
                    break;
                }
            }
            

        }

        private void addControls()
        {
            line1.SetUpLine(this, 1);
            line2.SetUpLine(this, 2);
            line3.SetUpLine(this, 3);
            line4.SetUpLine(this, 4);
            line5.SetUpLine(this, 5);
        }

        private void line1_Load(object sender, EventArgs e)
        {
            line1.SetEjectLabel(1);
        }

        private void line2_Load(object sender, EventArgs e)
        {
            line2.SetEjectLabel(2);
        }

        private void line3_Load(object sender, EventArgs e)
        {
            line3.SetEjectLabel(3);
        }

        private void line4_Load(object sender, EventArgs e)
        {
            line4.SetEjectLabel(4);
        }

        private void line5_Load(object sender, EventArgs e)
        {
            line5.SetEjectLabel(5);
        }
    }
}
