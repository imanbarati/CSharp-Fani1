using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Random1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int x = rnd.Next(0, this.Width - pictureBox1.Width - pictureBox2.Location.X);
            int y = rnd.Next(0, this.Height - pictureBox1.Height - pictureBox2.Location.Y);
            int r=rnd.Next(0,255);
            int g=rnd.Next(0,255);
            int b=rnd.Next(0,255);
            int d = rnd.Next(1, 7);
            pictureBox1.Location = new Point(x, y);
            pictureBox2.Size = new Size(x, y);
            pictureBox2.Location = new Point((x/2),(y/2));
            this.BackColor = Color.FromArgb(r,g,b);
            switch (d)
            {
                case 1:
                    pictureBox3.Image = Properties.Resources.Koala;
                    break;
                case 2:
                    pictureBox3.Image = Properties.Resources.Koala;
                    break;
                case 3:
                    pictureBox3.Image = Properties.Resources.Penguins;
                    break;
                case 4:
                    pictureBox3.Image = Properties.Resources.Jellyfish;
                    break;
                case 5:
                    pictureBox3.Image = Properties.Resources.Chrysanthemum;
                    break;
                case 6:
                    pictureBox3.Image = Properties.Resources.Tulips;
                    break;
                case 7:
                    pictureBox3.Image = Properties.Resources.Hydrangeas;
                    break;
            }
            textBox1.Text = DateTime.Now.ToString();
            textBox1.Location = new Point(x,y);
        }
    }
}
