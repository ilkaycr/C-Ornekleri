using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7.DersUygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int b = 2;
            string a = "4";
            //a %= b; //a = a%b;
            // ?: 
            // koşul?doğru_değer:yanlış_değer
            a = a + (b == 2 ? "örnek" : "günaydın");
            label1.Text = a.ToString();
        }
    }
}
