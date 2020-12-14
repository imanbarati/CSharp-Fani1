using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pasoor11_Random
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int t,t1,t2,t3, k;
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            k++;
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            t++;
            textBox3.Text = t.ToString();
            Random rnd = new Random();
            int num1 = rnd.Next(0, 13);
            int num2 = rnd.Next(0, 13);
            textBox1.Text = num1.ToString();
            textBox2.Text = num2.ToString();
            if ((num1 + num2) == 11)
            {
                timer1.Stop();
                if(k==1)
                {
                    textBox4.Text = (num1 + " , " + num2+" , "+t).ToString();
                    t1=t;
                    t = 0;
                }
                else if(k==2)
                {
                    textBox5.Text = (num1 + " , " + num2 + " , " + t).ToString();
                    t2=t;
                    t = 0;
                }
                else if (k == 3)
                {
                    textBox6.Text = (num1 + " , " + num2 + " , " + t).ToString();
                    t3 = t;
                    t = 0;
                    if (t1 <= t2 && t1 <= t3)
                        textBox7.Text = "First";
                    else if (t2 <= t1 && t2 <= t3)
                        textBox7.Text = "Second";
                    else if(t3<=t1 && t3<=t2)
                        textBox7.Text = "Third";
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            k = 0;
            textBox1.Text = "...";
            textBox2.Text = "...";
            textBox3.Text = "0";
            textBox4.Text = "...";
            textBox5.Text = "...";
            textBox6.Text = "...";
            textBox7.Text = "...";
        }
    }
}
