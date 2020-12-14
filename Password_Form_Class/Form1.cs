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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int k = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "SuperAdministrator" && textBox2.Text == "123456")
            {
                Class1.name = "Mohammad";
                Form pass = new Form2();
                pass.Show();
                
            }
            else if (textBox1.Text == "Administrator" && textBox2.Text == "24688642")
            {
                Class1.name = "Ali";
                Form pass = new Form2();
                pass.Show();
            }
            else if (textBox1.Text == "Admin" && textBox2.Text == "865432")
            {
                Class1.name = "Reza";
                Form pass = new Form2();
                pass.Show();
            }
            else if (textBox1.Text == "User" && textBox2.Text == "876543")
            {
                Class1.name = "Majid";
                Form pass = new Form2();
                pass.Show();
            }
            else
            {
                k++;
                if (k >= 3)
                {
                    MessageBox.Show("Your Username or Password has been Wrong for 3 times", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                }
            }
        }
    }
}
