using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OddEven_While
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = int.Parse(textBox1.Text);
            int k = 0, sum = 0,n=num;
            while (n > 0)
            {
                sum = (sum * 10) + (n % 10);
                n /= 10;
                k++;
            }
            textBox2.Text = k.ToString();
            textBox4.Text = (sum).ToString();
            if (num % 2 == 0)
            {
                textBox3.Text = "زوج";
                textBox6.Clear();
                int mul = 1;
                while (num > 0)
                {
                    textBox5.Text = (mul *= (num % 10)).ToString();
                    num /= 10;
                }
            }
            else
            {
                textBox3.Text = "فرد";
                textBox5.Clear();
                int sum1 = 0;
                while (num > 0)
                {
                    textBox6.Text = (sum1 += (num % 10)).ToString();
                    num /= 10;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double sum = 0, mul = 1, sum1 = 0, mul1 = 1 ;
            int num1 = int.Parse(textBox7.Text);
            int num2 = int.Parse(textBox8.Text);
            for (int i = 0; i < num1; i++)
            {
                sum = Math.Sqrt(sum + num2);
                mul = Math.Sqrt(mul * num2);
                sum1 = Math.Sqrt(sum + num1);
                mul1 = Math.Sqrt(mul * num1);
            }
            textBox9.Text = sum.ToString();
            textBox10.Text = mul.ToString();
        }
    }
}
