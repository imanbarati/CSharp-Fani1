using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Password_Form_Class
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = "Welcome " + Class1.name;
            if (Class1.name == "Mohammad")
                label2.Enabled = textBox1.Enabled = checkBox1.Enabled = checkBox2.Enabled = checkBox3.Enabled = radioButton1.Enabled = radioButton2.Enabled = radioButton3.Enabled = true;
            else if (Class1.name == "Ali")
                label2.Enabled = textBox1.Enabled = checkBox1.Enabled = checkBox2.Enabled = checkBox3.Enabled  = true;
            else if (Class1.name == "Reza")
                label2.Enabled = textBox1.Enabled  = true;
        }
        int k = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            k++;
            if (k == 60)
                Close();
        }

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            k = 0;
        }
    }
}
