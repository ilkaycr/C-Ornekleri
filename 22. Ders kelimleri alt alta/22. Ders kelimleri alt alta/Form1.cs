using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22.Ders_kelimleri_alt_alta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            int i, ks = 1;
            string cumle = textBox1.Text;
            for (i = 0; i < cumle.Length; i++)
                if (cumle.Substring(i, 1) == " ")
                    label2.Text += "\n";
                else
                    label2.Text += cumle.Substring(i, 1);

        }
    }
}
