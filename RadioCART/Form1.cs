using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
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

        string[] queue;

        public Form1()
        {
            InitializeComponent();
            mPlaylist = new List<String>();
            queue = new string[5]; //strings are nullable btw 
            addControls();
        }

        public string[] getQueue()
        {
            return queue;
        }

        public void playQueue(int i)
        {
            int startingid = i;
        }

        private void addControls()
        {
            line1.setUpLine(this, 1);
            line2.setUpLine(this, 2);
            line3.setUpLine(this, 3);
            line4.setUpLine(this, 4);
            line5.setUpLine(this, 5);
        }

        private void line1_Load(object sender, EventArgs e)
        {
            line1.setEjectLabel(1);
        }

        private void line2_Load(object sender, EventArgs e)
        {
            line2.setEjectLabel(2);
        }

        private void line3_Load(object sender, EventArgs e)
        {
            line3.setEjectLabel(3);
        }

        private void line4_Load(object sender, EventArgs e)
        {
            line4.setEjectLabel(4);
        }

        private void line5_Load(object sender, EventArgs e)
        {
            line5.setEjectLabel(5);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
