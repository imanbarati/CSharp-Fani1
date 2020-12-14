using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SumFunctionRef
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int sum(int a, int b)
        {
            a += b;
            return a;
        }
        public int suma(ref int a, int b)
        {
            a += b;
            return a;
        }
        public int sum(int x, int y, int z)
        {
            int k = x + y + z;
            return k;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int a=int.Parse(textBox1.Text);
            int b=int.Parse(textBox2.Text);
            textBox3.Text = sum(a,b).ToString();
            textBox4.Text = textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int b = int.Parse(textBox1.Text);
            textBox3.Text = suma(ref b, (int.Parse(textBox2.Text))).ToString();
            textBox4.Text = b.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox5.Text);
            int b = int.Parse(textBox6.Text);
            int c = int.Parse(textBox7.Text);
            label1.Text = (sum(a, b, c)).ToString();
        }
        public double sd(float x, float y, float z, float j, float f)
        {
            double s = 0;
            double m = (x + y + z + j + f) / 5;
            float[] a ={x,y,z,j,f};
            foreach(double w in a)
                s+=Math.Pow((w-m),2);
            s /= 5;
            s = Math.Sqrt(s);
            return s;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label2.Text = sd((float.Parse(textBox8.Text)), (float.Parse(textBox9.Text)), (float.Parse(textBox10.Text)), (float.Parse(textBox11.Text)), (float.Parse(textBox12.Text))).ToString();
        }
    }
}
