using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.axVLCPlugin21.playlist.add(@"http://bitdash-a.akamaihd.net/content/sintel/hls/video/250kbit.m3u8");
            this.axVLCPlugin21.playlist.play();
        }
    }
}
