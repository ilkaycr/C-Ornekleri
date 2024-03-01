using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16.Ders_Örnek_metotlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b;
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);
            if (radioButton1.Checked)
                label3.Text = topla(a, b).ToString();
            else if (radioButton2.Checked)
                label3.Text = cikar(a, b).ToString();
            else if (radioButton3.Checked)
                label3.Text = carp(a, b).ToString();
            else if (radioButton4.Checked)
                if (b == 0)
                    label3.Text = "Sıfıra bölme olmaz";
                else
                    label3.Text = bol(a, b).ToString();

        }
        private double topla(double a, double b)
        {
            return a + b;
        }
        private double cikar(double a, double b)
        {
            return a - b;
        }
        private double carp(double a, double b)
        {
            return a * b;
        }
        private double bol(double a, double b)
        {
            return a / b;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
