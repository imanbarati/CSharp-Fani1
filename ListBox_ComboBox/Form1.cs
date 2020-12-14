using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ListBox_ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 5; i++)
            {
                for (int j = 1; j <= i; j++)
                    listBox1.Items.Add(string.Format("{0}.{1}",i,j));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 9; i++)
                listBox2.Items.Add(string.Format("{0}.{1}", i, 9 - i));
        }
        string[] month = { "فروردین", "اردیبهشت", "خرداد", "تیر", "مرداد", "شهریور", "مهر", "آبان", "آذر", "دی", "بهمن", "اسفند" };
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1300; i <= 1397; i++)
            {
                comboBox1.Items.Add(i);
                comboBox8.Items.Add(i);
            }
            for (int i = 0; i < 12; i++)
            {
                comboBox2.Items.Add(month[i]);
                comboBox10.Items.Add(month[i]);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex < 6)
                {
                    comboBox3.Items.Clear();
                    for (int i = 1; i <= 31; i++)
                        comboBox3.Items.Add(i);
                }
            else if (comboBox2.SelectedIndex < 11)
                {
                    comboBox3.Items.Clear();
                    for (int i = 1; i <= 30; i++)
                        comboBox3.Items.Add(i);
                }
                else
                {
                    comboBox3.Items.Clear();
                    for (int i = 1; i <= 29; i++)
                        comboBox3.Items.Add(i);
                }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            label4.Text = string.Format("{0:00}/{1:00}/{2:0000}", comboBox3.SelectedItem, comboBox2.SelectedItem, comboBox1.SelectedItem);

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox6.SelectedIndex == 0)
            {
                comboBox5.Items.Clear();
                comboBox5.Items.Add("اصفهان");
                comboBox5.Items.Add("شهرضا");
                comboBox5.Items.Add("شاهین شهر");
                comboBox5.Items.Add("خمینی شهر");
            }
            else if (comboBox6.SelectedIndex == 1)
            {
                comboBox5.Items.Clear();
                comboBox5.Items.Add("تهران");
                comboBox5.Items.Add("ورامین");
                comboBox5.Items.Add("شهریار");
                comboBox5.Items.Add("ری");
            }
            else if (comboBox6.SelectedIndex == 2)
            {
                comboBox5.Items.Clear();
                comboBox5.Items.Add("شیراز");
                comboBox5.Items.Add("کازرون");
                comboBox5.Items.Add("جهرم");
                comboBox5.Items.Add("آباده");
            }
            else if (comboBox6.SelectedIndex == 3)
            {
                comboBox5.Items.Clear();
                comboBox5.Items.Add("مشهد");
                comboBox5.Items.Add("تربت حیدریه");
                comboBox5.Items.Add("کاشمر");
                comboBox5.Items.Add("سبزوار");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label5.Text = string.Format("{0} - {1}", comboBox6.SelectedItem, comboBox5.SelectedItem);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label10.Text = comboBox7.SelectedItem.ToString()+" "+ textBox1.Text+" "+ textBox2.Text+" با تحصیلات "+comboBox4.SelectedItem.ToString()+" سن شما "+ (1397 - int.Parse(textBox3.Text)).ToString()+" می باشد .";
        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox9.SelectedIndex)
            {
                case 0:
                    pictureBox1.Image = Properties.Resources.Desert;
                    break;
                case 1:
                    pictureBox1.Image = Properties.Resources.Jellyfish;
                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.Tulips;
                    break;
            }
        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox10.SelectedIndex < 6)
            {
                comboBox11.Items.Clear();
                for (int i = 1; i <= 31; i++)
                    comboBox11.Items.Add(i);
            }
            else if (comboBox10.SelectedIndex < 11)
            {
                comboBox11.Items.Clear();
                for (int i = 1; i <= 30; i++)
                    comboBox11.Items.Add(i);
            }
            else
            {
                comboBox11.Items.Clear();
                for (int i = 1; i <= 29; i++)
                    comboBox11.Items.Add(i);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int a = int.Parse(comboBox8.SelectedItem.ToString());
            if (comboBox10.SelectedIndex < 10 && comboBox11.SelectedIndex < 10)
                label16.Text = "سال تولد شما به میلادی "+(a + 621).ToString()+" است.";
            else
                label16.Text = "سال تولد شما به میلادی " + (a + 622).ToString() + " است.";
        }
    }
}
