using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clock_Timer
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        int a=0,b=0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            int s=int.Parse(textBox1.Text);
            int m=int.Parse(textBox2.Text);
            int h=int.Parse(textBox3.Text);
            s++;
            if (s == 10)
            {
                s = 0;
                m++;
                if (m == 10)
                {
                    m = 0;
                    h++;
                }
            }
            textBox1.Text = (s).ToString();
            textBox2.Text = (m).ToString();
            textBox3.Text = (h).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            textBox1.Text = (0).ToString();
            textBox2.Text = (0).ToString();
            textBox3.Text = (0).ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int a=int.Parse(textBox4.Text);
            textBox4.Text = (a-1).ToString();
            if (a == 0)
                this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer2.Stop();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            timer2.Stop();
            textBox4.Text = (10).ToString();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left += a;
            if (pictureBox1.Location.X <= 12)
                a = +5;
            if(pictureBox1.Location.X>=(this.Width-pictureBox1.Width-20))
                a = -5;
           }

        private void timer4_Tick(object sender, EventArgs e)
        {
            b++;
            if (b == 8)
                b = 1;
            switch (b)
            {
                case 1:
                    pictureBox2.Image = Properties.Resources.Koala;
                    break;
                case 2:
                    pictureBox2.Image = Properties.Resources.Koala;
                    break;
                case 3:
                    pictureBox2.Image = Properties.Resources.Penguins;
                    break;
                case 4:
                    pictureBox2.Image = Properties.Resources.Jellyfish;
                    break;
                case 5:
                    pictureBox2.Image = Properties.Resources.Chrysanthemum;
                    break;
                case 6:
                    pictureBox2.Image = Properties.Resources.Tulips;
                    break;
                case 7:
                    pictureBox2.Image = Properties.Resources.Hydrangeas;
                    break;
            }
            
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            b++;
            if (b == 8)
                b = 1;
            switch (b)
            {
                case 3:
                    this.BackgroundImage = Properties.Resources.Koala;
                    break;
                case 4:
                    this.BackgroundImage = Properties.Resources.Koala;
                    break;
                case 2:
                    this.BackgroundImage = Properties.Resources.Penguins;
                    break;
                case 1:
                    this.BackgroundImage = Properties.Resources.Jellyfish;
                    break;
                case 6:
                    this.BackgroundImage = Properties.Resources.Chrysanthemum;
                    break;
                case 7:
                    this.BackgroundImage = Properties.Resources.Tulips;
                    break;
                case 5:
                    this.BackgroundImage = Properties.Resources.Hydrangeas;
                    break;
            }
            
        }

        private void timer6_Tick(object sender, EventArgs e)
       {
            pictureBox3.Height += 10;
           pictureBox3.Width += 10;
           pictureBox3.Left -= 5;
           pictureBox3.Top -= 5;
           if((pictureBox3.Width>=this.Width)||(pictureBox3.Height>=this.Height))
           {
               pictureBox3.Height=50;
               pictureBox3.Width=100;
               pictureBox3.Location = new Point(((this.Width-pictureBox3.Height)/2),((this.Height-pictureBox3.Height)/2)); 
           }
        }
    }
}
