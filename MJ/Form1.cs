using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CalculatorRGB
{
    
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            float a = float.Parse(textBox1.Text);
            float b = float.Parse(textBox2.Text);
            label1.Text = ( a + b ).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            float a = float.Parse(textBox1.Text);
            float b = float.Parse(textBox2.Text);
            label1.Text = (a - b).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            float a = float.Parse(textBox1.Text);
            float b = float.Parse(textBox2.Text);
            label1.Text = (a * b).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            float a = float.Parse(textBox1.Text);
            float b = float.Parse(textBox2.Text);
            label1.Text = (a / b).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            float a = float.Parse(textBox1.Text);
            float b = float.Parse(textBox2.Text);
            label1.Text = (a % b).ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            float a = float.Parse(textBox1.Text);
            float b = float.Parse(textBox2.Text);
            label1.Text = Math.Min(a,b).ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            float a = float.Parse(textBox1.Text);
            float b = float.Parse(textBox2.Text);
            label1.Text = Math.Max(a,b).ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            float a = float.Parse(textBox1.Text);
            float b = float.Parse(textBox2.Text);
            label1.Text = ((a + b)/2).ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            float a = float.Parse(textBox1.Text);
            float b = float.Parse(textBox2.Text);
            float c=1;
            for (int i = 0; i < b; i++)
                c *= a;
            label1.Text =c.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.BackColor = Color.Yellow;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Pink;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Purple;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromName(textBox3.Text);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox4.Text);
            int b = int.Parse(textBox5.Text);
            int c = int.Parse(textBox6.Text);
            if (a >= 0 && b >= 0 && c >= 0 && a < 255 && b < 255 && c < 255)
                this.BackColor = Color.FromArgb(a, b, c);
            else
                MessageBox.Show("Error", "Warning");
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button19_Click(object sender, EventArgs e)
        {
           
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            textBox4.Text = (trackBar1.Value).ToString();
            textBox5.Text = (trackBar2.Value).ToString();
            textBox6.Text = (trackBar3.Value).ToString();
            this.BackColor = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            textBox4.Text = (trackBar1.Value).ToString();
            textBox5.Text = (trackBar2.Value).ToString();
            textBox6.Text = (trackBar3.Value).ToString();
            this.BackColor = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            textBox4.Text = (trackBar1.Value).ToString();
            textBox5.Text = (trackBar2.Value).ToString();
            textBox6.Text = (trackBar3.Value).ToString();
            this.BackColor = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);
        }
    }
}
