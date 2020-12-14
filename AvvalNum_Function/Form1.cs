using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AvvalNum_Function
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string AvvalNum(int n)
        {
            int k;
            string m="Avval";
            for (int i = 2; i <= (n/2); i++)
            {
                k = n % i;
                if (k == 0)
                {
                    m = "Not Avval";
                    break;
                }
           }
            if (n == 0 || n == 1)
                m = "Not Avval";
            return m;
        }
        public int factre(int m)
        {
            if (m == 1)
                return 1;
            else
                return factre(m - 1) * m;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);
            label1.Text = AvvalNum(n);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = factre(int.Parse(textBox1.Text)).ToString(); 
        }


    }
}
