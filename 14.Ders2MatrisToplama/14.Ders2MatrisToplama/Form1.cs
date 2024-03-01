using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14.Ders2MatrisToplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i, j;
            int n = Convert.ToInt32(textBox1.Text);
            int[,] a = new int[n + 1, n + 1];
            int[,] b = new int[n + 1, n + 1];
            string satir1 = "", satir2 = "", satir3 = "";
            for ( i = 1; i <= n; i++)
            {
                satir1 = "";satir2 = "";satir3 = "";
                for ( j = 1; j <= n; j++)
                {
                    a[i, j] = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("A(" + i + "," + j + ") elemanını giriniz", "A Matrisi", "", 100, 100));
                    satir1 += a[i, j].ToString() + "       ";

                    b[i, j] = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("B(" + i + "," + j + ") elemanını giriniz", "B Matrisi", "", 100, 100));
                    satir2 += b[i, j].ToString() + "       ";

                    satir3 += (a[i, j] + b[i, j]).ToString() + "    ";
                }
                listBox1.Items.Add(satir1);
                listBox2.Items.Add(satir2);
                listBox3.Items.Add(satir3);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
