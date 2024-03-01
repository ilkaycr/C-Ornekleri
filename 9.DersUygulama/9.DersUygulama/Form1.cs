using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9.DersUygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // switch deyimi


            // switch (ifade)
            // { 
            //case sabit1:
            //  deyim1;
            //  break
            //case sabit2:
            //  deyim2;
            //  break
            //case sabit3:
            //  deyim3;
            //  break
            //...
            //default:                    bunun zorunluluğu yok
            //  deyim
            //  break;
            // }

            int a = 5;
            switch (a)
            {
                case 1:
                    label1.Text = "a nın değeri 1 dir";
                    break;

                case 3:
                    label1.Text = "a nın değeri 3 dir";
                    break;
                case 5:
                    label1.Text = "a nın değeri 5 dir";
                    break;
                default:
                    label1.Text = "a nın değeri 1 3 5 değildir";
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = 1;
            switch (a)
            {
                case 1:
                    goto case 5;       // case 5 e gönderir
                case 3:
                    label2.Text = "a nın değeri 3 dür";
                    break;
                case 5:
                    label2.Text = "a nın değeri 5 tir.";
                    break;
                default:
                    label2.Text = " a nın değeri 1 3 5 değildir";
                    break;




            }
        }
    }
}
