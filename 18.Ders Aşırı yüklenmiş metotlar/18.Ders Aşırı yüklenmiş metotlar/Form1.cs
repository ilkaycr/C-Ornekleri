using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18.Ders_Aşırı_yüklenmiş_metotlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // aşırı yüklenmiş metotlar
            // aynı isimli birden fazla metot tanımladığımız zaman bu metot aşırı yüklenmiş metot oluyor
            label1.Text = topla(1, 2).ToString();
        }
        int topla(int a,int b)
        {
            return a + b;
        }

        double topla(double a, int b)
        {
            return a + b;
        }

        int topla(int a, int b, int c)
        {
            return a + b + c;
        }

    }
}
