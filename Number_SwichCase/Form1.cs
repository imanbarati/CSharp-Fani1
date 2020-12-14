using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Number_SwichCase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string a, b, c;
        private void button1_Click(object sender, EventArgs e)
        {
            a = b = c = null;
            int num = int.Parse(textBox1.Text);
            int d = num % 10;
            int j = (num / 10) % 10;
            int f = (num / 100) % 10;
            switch (d)
                {
                case 1:
                        a = "یک";
                        break;
                    case 2:
                        a = "دو";
                        break;
                    case 3:
                        a = "سه";
                        break;
                    case 4:
                        a = "چهار";
                        break;
                    case 5:
                        a = "پنج";
                        break;
                    case 6:
                        a = "شش";
                        break;
                    case 7:
                        a = "هفت";
                        break;
                    case 8:
                        a = "هشت";
                        break;
                    case 9:
                        a = "نه";
                        break;
                }
            switch (j)
            {
                case 1:
                    switch (d )
                    {
                        case 0:
                            a = "ده";
                            break;
                        case 1:
                            a = "یازده";
                            break;
                        case 2:
                            a = "دوازده";
                            break;
                        case 3:
                            a = "سیزده";
                            break;
                        case 4:
                            a = "چهارده";
                            break;
                        case 5:
                            a = "پانزده";
                            break;
                        case 6:
                            a = "شانزده";
                            break;
                        case 7:
                            a = "هفتده";
                            break;
                        case 8:
                            a = "هیجده";
                            break;
                        case 9:
                            a = "نوزده";
                            break;
                    }
                        break;
                    case 2:
                        b = "بیست ";
                        break;
                    case 3:
                        b = "سی ";
                        break;
                    case 4:
                        b = "چهل ";
                        break;
                    case 5:
                        b = "پنجاه ";
                        break;
                    case 6:
                        b = "شصت ";
                        break;
                    case 7:
                        b = "هفتاد ";
                        break;
                    case 8:
                        b = "هشتاد ";
                        break;
                    case 9:
                        b = "نود ";
                        break;
            }
            switch (f)
            {
                case 1:
                    c = "صد ";
                    break;
                case 2:
                    c = "دویست ";
                    break;
                case 3:
                    c = "سیصد ";
                    break;
                case 4:
                    c = "چهارصد ";
                    break;
                case 5:
                    c = "پانصد ";
                    break;
                case 6:
                    c = "ششصد ";
                    break;
                case 7:
                    c = "هفتصد ";
                    break;
                case 8:
                    c = "هشتصد ";
                    break;
                case 9:
                    c = "نهصد ";
                    break;
            }
            label2.Text = null;
            if (textBox1.TextLength == 1 && d == 0)
                label2.Text = "صفر";
            else
                label2.Text =string.Format("{0} {1} {2}",c,b,a);
        }
    }
}
