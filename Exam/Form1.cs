using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Exam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 0, b = 0, c = 0;
            if (radioButton2.Checked == true)
                a++;
            else if (radioButton1.Checked == true || radioButton3.Checked == true || radioButton4.Checked == true)
                b++;
            else
                c++;
            if (radioButton5.Checked == true)
                a++;
            else if (radioButton6.Checked == true || radioButton7.Checked == true || radioButton8.Checked == true)
                b++;
            else
                c++;
            if (radioButton11.Checked == true)
                a++;
            else if (radioButton9.Checked == true || radioButton10.Checked == true || radioButton12.Checked == true)
                b++;
            else
                c++;
            if (radioButton16.Checked == true)
                a++;
            else if (radioButton13.Checked == true || radioButton14.Checked == true || radioButton15.Checked == true)
                b++;
            else
                c++;
            if (radioButton18.Checked == true)
                a++;
            else if (radioButton17.Checked == true || radioButton19.Checked == true || radioButton20.Checked == true)
                b++;
            else
                c++;
            if (radioButton23.Checked == true)
                a++;
            else if (radioButton21.Checked == true || radioButton22.Checked == true || radioButton24.Checked == true)
                b++;
            else
                c++;
            if (radioButton27.Checked == true)
                a++;
            else if (radioButton25.Checked == true || radioButton26.Checked == true || radioButton28.Checked == true)
                b++;
            else
                c++;
            if (radioButton32.Checked == true)
                a++;
            else if (radioButton29.Checked == true || radioButton30.Checked == true || radioButton31.Checked == true)
                b++;
            else
                c++;
            if (radioButton33.Checked == true)
                a++;
            else if (radioButton34.Checked == true || radioButton35.Checked == true || radioButton36.Checked == true)
                b++;
            else
                c++;
            if (radioButton40.Checked == true)
                a++;
            else if (radioButton37.Checked == true || radioButton38.Checked == true || radioButton39.Checked == true)
                b++;
            else
                c++;
            textBox1.Text = (a).ToString();
            textBox2.Text = (b).ToString();
            textBox3.Text = (c).ToString();
            textBox4.Text = (a * 10).ToString()+" %";
            textBox5.Text = ((a * 3 - b) * 10).ToString() + " %";
            textBox6.Text = ((a * 3 - b) * 10).ToString();
            if (((a * 3 - b) * 10) >= 70)
            {
                label18.Text = "قبول";
                label18.ForeColor = Color.Green;
            }
            else
            {
                label18.Text = "مردود";
                label18.ForeColor = Color.Red;
            }
        }
    }
}
