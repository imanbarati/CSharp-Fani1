using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Array
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextBox z,y;
            Button x;
            Controls.Clear();
            Controls.Add(z=new TextBox());
            z.Location = new Point(20, 20);
            Controls.Add(y = new TextBox());
            y.Location = new Point(140, 20);
            Controls.Add(x = new Button());
            x.Location = new Point(270, 20);
            x.Text="Creat";

            int a = int.Parse(textBox1.Text);
            int d = int.Parse(textBox2.Text);
            Random rnd = new Random();
            TextBox[,] t = new TextBox[a, d];
            Label[,] l = new Label[a, d];
            for(int i=0;i<a;i++)
                for (int j = 0; j < d; j++)
                {
                    int r = rnd.Next(10,255);
                    int g = rnd.Next(10,255);
                    int b = rnd.Next(10,255);
                    t[i, j] = new TextBox();
                    t[i, j].Location = new Point(j * 120 + 20, i * 25 + 50);
                    t[i, j].Size = new Size(40, 20);
                    t[i, j].Text = ((i + 1) * (j + 1)).ToString();
                    t[i, j].ForeColor = Color.FromArgb(r,g,b);
                    l[i, j] = new Label();
                    l[i, j].Location = new Point(j * 120 + 60, i * 25 + 50);
                    l[i, j].Size = new Size(40, 20);
                    l[i, j].Text = "(" + i + "," + j + ")";
                    l[i, j].ForeColor = Color.Red;
                    
                    
                    Controls.Add(t[i, j]);
                    Controls.Add(l[i, j]);
                }
        }
    }
}
