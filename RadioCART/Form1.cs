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
using System.Windows.Media;

//TODO: add song to queue if you switch it out while its checked

namespace RadioCART
{
    public partial class Form1 : Form
    {
        public QueuePlayer QueuePlayer { get; private set; }
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

        private Line[] mQueue;

        public Line[] Queue
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

        private MediaPlayer player;


        public Form1()
        {
            InitializeComponent();
            mPlaylist = new List<String>();
            mQueue = new Line[5]; //strings are nullable btw 
            player = new MediaPlayer();
            addControls();
            QueuePlayer = new QueuePlayer();
        }

        public Queue<Line> ReorderQueue(int start)
        {
            Queue<Line> ret = new Queue<Line>();
            int i = start;

            while (true)
            {
                if (mQueue[i] != null)
                {
                    ret.Enqueue(mQueue[i]);
                }

                i++;
                if (i == mQueue.Length)
                {
                    i = 0;
                }
                if (i == start)
                {
                    break;
                }
            }

            return ret;
        }

        private void addControls()
        {
            line1.SetUpLine(this, 0);
            line2.SetUpLine(this, 1);
            line3.SetUpLine(this, 2);
            line4.SetUpLine(this, 3);
            line5.SetUpLine(this, 4);
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

        private void unloadAll_Click(object sender, EventArgs e)
        {
            line1.ClearLine();
            line2.ClearLine();
            line3.ClearLine();
            line4.ClearLine();
            line5.ClearLine();
        }
    }
}
