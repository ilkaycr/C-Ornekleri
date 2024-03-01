using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7.DersUygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int  a = 5;
            //Karar yapıları
            //if , switch deyimi
            
            //-----if deyimi -----
           
            // if(koşul)
            //   deyim1;
            // else if (koşul2)
            //          deyim2;
            //      else
            //          deyim3;
            
            if (a == 3) {
                label1.Text = a.ToString();  // tek  satır varsa küme parantezine gerek yok 
            }

            else
            {
                label2.Text = a.ToString();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            double f;
            if (x >= 0)
                f = Math.Pow(x, 2); // karesini almak
            else
                f = Math.Abs(x);    // mutlak değer
            label3.Text = f.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox2.Text);
            double f;
            if (x > 0)
                f = Math.Pow(x, 2);
            else if (x == 0)
                    f = Math.Sin(x);
                else
                    f = Math.Abs(x);
            label4.Text = f.ToString();
        }
    }
}
