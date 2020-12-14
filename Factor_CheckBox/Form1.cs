using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Factor_CheckBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            float sum = (float.Parse(textBox4.Text)) + (float.Parse(textBox5.Text)) + (float.Parse(textBox9.Text)) + (float.Parse(textBox13.Text));
            label5.Text = (sum * 94 / 100).ToString() + " $";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            float sum = (float.Parse(textBox4.Text)) + (float.Parse(textBox5.Text)) + (float.Parse(textBox9.Text)) + (float.Parse(textBox13.Text));
            label5.Text = sum.ToString() + " $";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            if (checkBox1.Checked == false)
            {
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                textBox4.Enabled = false;
            }
        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox4.Text = ((float.Parse(textBox2.Text)) * (float.Parse(textBox3.Text))).ToString();
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            textBox4.Text = ((float.Parse(textBox2.Text)) * (float.Parse(textBox3.Text))).ToString();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            textBox5.Enabled = true;
            textBox6.Enabled = true;
            textBox7.Enabled = true;
            textBox8.Enabled = true;
            if (checkBox1.Checked == false)
            {
                textBox5.Enabled = false;
                textBox6.Enabled = false;
                textBox7.Enabled = false;
                textBox8.Enabled = false;
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            textBox5.Text = ((float.Parse(textBox6.Text)) * (float.Parse(textBox7.Text))).ToString() ;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            textBox5.Text = ((float.Parse(textBox6.Text)) * (float.Parse(textBox7.Text))).ToString() ;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            textBox9.Enabled = true;
            textBox10.Enabled = true;
            textBox11.Enabled = true;
            textBox12.Enabled = true;
            if (checkBox1.Checked == false)
            {
                textBox9.Enabled = false;
                textBox10.Enabled = false;
                textBox11.Enabled = false;
                textBox12.Enabled = false;
            }
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            textBox9.Text = ((float.Parse(textBox10.Text)) * (float.Parse(textBox11.Text))).ToString();
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            textBox9.Text = ((float.Parse(textBox10.Text)) * (float.Parse(textBox11.Text))).ToString();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            textBox13.Enabled = true;
            textBox14.Enabled = true;
            textBox15.Enabled = true;
            textBox16.Enabled = true;
            if (checkBox1.Checked == false)
            {
                textBox13.Enabled = false;
                textBox14.Enabled = false;
                textBox15.Enabled = false;
                textBox16.Enabled = false;
            }
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            textBox13.Text = ((float.Parse(textBox14.Text)) * (float.Parse(textBox15.Text))).ToString() ;
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            textBox13.Text = ((float.Parse(textBox14.Text)) * (float.Parse(textBox15.Text))).ToString() ;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float sum = (float.Parse(textBox4.Text)) + (float.Parse(textBox5.Text)) + (float.Parse(textBox9.Text)) + (float.Parse(textBox13.Text));
            if (radioButton1.Checked == true)
                label5.Text = sum.ToString() + " $";
            if (radioButton2.Checked == true)
                label5.Text = (sum * 94/100).ToString() + " $";
        }
    }
}
