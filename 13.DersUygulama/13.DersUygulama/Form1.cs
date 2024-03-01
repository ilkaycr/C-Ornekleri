using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13.DersUygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i, j, n, toplam = 0;
            n = Convert.ToInt32(textBox1.Text);
            int[,] a = new int[n+1, n+1];
            string satir = " ";
            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= n; j++)
                {
                    a[i, j] = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("A[" + i + "," + j + "] i giriniz", "Matris Giriniz", "", 100, 100));
                    if (i == 2 || j == 3)
                        toplam += a[i, j];
                    satir += a[i, j] + "    ";

                }
                listBox1.Items.Add(satir);
                satir = " ";
            }
            label3.Text = "Sonuç" + toplam;
        
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
