using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace IdMobile_Class_DataGridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Id> mob_id=new List<Id>();
        int k=0;
        private void button1_Click(object sender, EventArgs e)
        {
            k++;
            if (k == 1)
            {
                mob_id.Add(new Id(1234, 2017, "Iphone", "Black", "IOS", "ST7"));
                mob_id.Add(new Id(2436, 2018, "Samsung", "White", "Android", "j8207"));
                mob_id.Add(new Id(2045, 2017, "Huawey", "Red", "Android", "S4"));
                mob_id.Add(new Id(3001, 2000, "Nokia", "Grey", "None", "1100"));
                mob_id.Add(new Id(1267, 2014, "Blackbary", "Black", "Bos", "Q10"));
            }
            try
            {
                mob_id.Add(new Id((decimal.Parse(textBox1.Text)), (decimal.Parse(textBox4.Text)), (textBox2.Text), (textBox3.Text), (textBox5.Text), (textBox6.Text)));
            }
            catch { }
            dataGridView1.AutoGenerateColumns = true;
            bindingSource1.DataSource = mob_id.ToList();
        }
    }
}
