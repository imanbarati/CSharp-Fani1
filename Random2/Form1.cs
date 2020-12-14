using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Random2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        int t = 0, x;
        Random rnd = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            t++;
            x = rnd.Next(0, 11);
            textBox3.Text = t.ToString();
            textBox2.Clear();
            this.BackColor = DefaultBackColor;
            if ((t < 15) && (x == (int.Parse(textBox1.Text))))
            {
                timer1.Stop();
                this.BackColor = Color.Blue;
                textBox2.Text = t.ToString();
                MessageBox.Show("It's Done!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                t = 0;
            }
            if ((t == 15) && (x!= (int.Parse(textBox1.Text))))
            {
                timer1.Stop();
                this.BackColor = Color.Red;
                MessageBox.Show("Time's Over!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
    }
}
