using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8.DersUygulamaDelta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, c;
            double d, x1, x2;
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            c = Convert.ToInt32(textBox3.Text);
            d = b * b - (4 * a * c);
            if (d > 0)
            {
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);
                label4.Text = "x1 = " + x1 + ", x2 = " + x2;
            }
            else if (d == 0)
            {
                x1 = -b / (2 * a);
                label4.Text = "x1=" + x1;
            }
            else
                label4.Text = "Reel kök yoktur";


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
