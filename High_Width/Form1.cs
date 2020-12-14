using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Picture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Width -= 10;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Height += 10;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Width += 10;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Height -= 10;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox1.Top -= 10;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pictureBox1.Top -= 10;
            pictureBox1.Left += 10;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pictureBox1.Left += 10;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            pictureBox1.Top += 10;
            pictureBox1.Left += 10;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            pictureBox1.Top += 10;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            pictureBox1.Top += 10;
            pictureBox1.Left -=10;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            pictureBox1.Left -= 10;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            pictureBox1.Top -=10;
            pictureBox1.Left -= 10;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //pictureBox1.Image = Image.FromFile("C:\\Users\\Public\\Pictures\\Sample Pictures\\Tulips.jpg");
            //pictureBox1.Image = Image.FromFile(@"C:\Users\Public\Pictures\Sample Pictures\Tulips.jpg");
            //pictureBox1.Image = Image.FromFile(Application.StartupPath+"//Tulips.jpg");
            //pictureBox1.Image = Image.FromFile(textBox1.Text);
            openFileDialog1.ShowDialog();
            pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            int x=pictureBox1.Location.X;
            int y=pictureBox1.Location.Y;
            pictureBox1.Height += 10;
            pictureBox1.Width += 10;
            pictureBox1.Location = new Point(x -= 5, y -= 5);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            int x = pictureBox1.Location.X;
            int y = pictureBox1.Location.Y;
            pictureBox1.Height -= 10;
            pictureBox1.Width -= 10;
            pictureBox1.Location = new Point(x += 5, y += 5);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            pictureBox1.Height = this.Height;
            pictureBox1.Width = this.Width;
            pictureBox1.Location = new Point(0, 0);
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            pictureBox1.Height = this.Height;
            pictureBox1.Width = this.Width;
            pictureBox1.Location = new Point(0, 0);
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            int x = pictureBox1.Location.X;
            int y = pictureBox1.Location.Y;
            pictureBox1.Height += 40;
            pictureBox1.Width += 40;
            pictureBox1.Location = new Point(x -= 20, y -= 20);
        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            int x = pictureBox1.Location.X;
            int y = pictureBox1.Location.Y;
            pictureBox1.Height -= 40;
            pictureBox1.Width -= 40;
            pictureBox1.Location = new Point(x += 20, y += 20);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox1.Image = Image.FromFile(Application.StartupPath + "//Tulips.jpg");
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            //pictureBox1.Image = Image.FromFile(Application.StartupPath + "//Tulips.jpg");
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            //pictureBox1.Image = Image.FromFile(Application.StartupPath + "//Tulips.jpg");
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox1.Image = Properties.Resources.Koala;
        }
    }
}
