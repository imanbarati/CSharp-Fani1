using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Game_Random
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //System.Diagnostics.Process.Start("wmplayer.exe");
            timer1.Start();
            PictureBox a = new PictureBox(), b = new PictureBox(), c = new PictureBox();
            Random rnd = new Random();
            int x1 = rnd.Next(this.Width - a.Width);
            int y1 = rnd.Next(this.Height - a.Height);
            int x2 = rnd.Next(this.Width - b.Width);
            int y2 = rnd.Next(this.Height - b.Height);
            int x3 = rnd.Next(this.Width - c.Width);
            int y3 = rnd.Next(this.Height - c.Height);
            Controls.Add(a);
            Controls.Add(b);
            Controls.Add(c);
            
        }
    }
}
