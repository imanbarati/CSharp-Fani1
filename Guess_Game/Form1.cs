using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Guess_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int t,num1,num2,num3,num4;
        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            num1 = rnd.Next(0, 26);
            num2 = rnd.Next(0, 26);
            num3 = rnd.Next(0, 26);
            num4 = rnd.Next(0, 26);
            radioButton1.Enabled = radioButton2.Enabled = radioButton3.Enabled = false;
            timer1.Start();
            textBox1.Enabled = textBox2.Enabled = textBox3.Enabled = textBox4.Enabled = textBox5.Enabled = true;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            t--;
            textBox5.Text = string.Format("{0:00}", t);
            try
            {
                if ((int.Parse(textBox1.Text) == num1) && (int.Parse(textBox2.Text) == num2) && (int.Parse(textBox3.Text) == num3) && (int.Parse(textBox4.Text) == num4))
                {
                    timer1.Stop();
                    groupBox1.BackColor = Color.Green;
                    MessageBox.Show(("You Win ! \nNum1 is =" + num1 + ", Num2 is =" + num2 + ", Num3 is =" + num3 + ", Num4 is =" + num4 + ", and Sum is =" + (num1 + num2 + num3 + num4) + ", and Time is =" + (40 - t)), "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    button1.Enabled = false;
                }
                else if (t == 0)
                {
                    timer1.Stop();
                    groupBox1.BackColor = Color.Red;
                    MessageBox.Show("You Lose ! \nTime's Over!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    button1.Enabled = false;
                }
            }
            catch { }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label5.Visible = true;
            label5.ForeColor = Color.Red;
            try
            {
                if (int.Parse(textBox1.Text) > 25)
                    textBox1.Text = (25).ToString();
                if (int.Parse(textBox1.Text) < num1)
                    label5.Text = "بزرگترتر";
                else if (int.Parse(textBox1.Text) > num1)
                    label5.Text = "کوچکترتر";
                else if (int.Parse(textBox1.Text) == num1)
                {
                    label5.ForeColor = Color.Green;
                    label5.Text = "صد آفرین";
                    textBox1.Enabled = false;
                    label9.Visible = true;
                    label9.Text = num1.ToString();
                    pictureBox1.Visible = true;
                }
            }
            catch { }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            label6.Visible = true;
            label6.ForeColor = Color.Red;
            try
            {
                if (int.Parse(textBox2.Text) > 25)
                    textBox2.Text = (25).ToString();
                if (int.Parse(textBox2.Text) < num2)
                    label6.Text = "بزرگترتر";
                else if (int.Parse(textBox2.Text) > num2)
                    label6.Text = "کوچکترتر";
                else if (int.Parse(textBox2.Text) == num2)
                {
                    label6.ForeColor = Color.Green;
                    label6.Text = "صد آفرین";
                    textBox2.Enabled = false;
                    label10.Visible = true;
                    label10.Text = num2.ToString();
                    pictureBox2.Visible = true;
                }
            }
            catch { }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            label7.Visible = true;
            label7.ForeColor = Color.Red;
            try
            {
                if (int.Parse(textBox3.Text) > 25)
                    textBox3.Text = (25).ToString();
                if (int.Parse(textBox3.Text) < num3)
                    label7.Text = "بزرگترتر";
                else if (int.Parse(textBox3.Text) > num3)
                    label7.Text = "کوچکترتر";
                else if (int.Parse(textBox3.Text) == num3)
                {
                    label7.ForeColor = Color.Green;
                    label7.Text = "صد آفرین";
                    textBox3.Enabled = false;
                    label11.Visible = true;
                    label11.Text = num3.ToString();
                    pictureBox3.Visible = true;
                }
            }
            catch { }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            label8.Visible = true;
            label8.ForeColor = Color.Red;
            try
            {
                if (int.Parse(textBox4.Text) > 25)
                    textBox4.Text = (25).ToString();
                if (int.Parse(textBox4.Text) < num4)
                    label8.Text = "بزرگترتر";
                else if (int.Parse(textBox4.Text) > num4)
                    label8.Text = "کوچکترتر";
                else if (int.Parse(textBox4.Text) == num4)
                {
                    label8.ForeColor = Color.Green;
                    label8.Text = "صد آفرین";
                    textBox4.Enabled = false;
                    label12.Visible = true;
                    label12.Text = num4.ToString();
                    pictureBox4.Visible = true;
                }
            }
            catch { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            textBox5.Text ="...";
            groupBox1.BackColor = Color.LightSkyBlue;
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = "0";
            radioButton1.Enabled = radioButton2.Enabled = radioButton3.Enabled = true;
            label5.Visible = label6.Visible = label7.Visible = label8.Visible = label9.Visible = label10.Visible = label11.Visible = label12.Visible = pictureBox1.Visible = pictureBox2.Visible = pictureBox3.Visible = pictureBox4.Visible = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            t = 60;
            button1.Enabled = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            t = 40;
            button1.Enabled = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            t = 20;
            button1.Enabled = true;
        }
    }
}
