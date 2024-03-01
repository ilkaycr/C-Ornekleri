using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15.Ders_Matrisler_Çarpımı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            int n, m, r, i, j, k, t;
            n = int.Parse(textBox1.Text);   //conver.toint32 = int.parse
            m = int.Parse(textBox2.Text);
            textBox3.Text  = m.ToString();
            r = int.Parse(textBox4.Text);
            int[,] a = new int[n + 1, m + 1];
            int[,] b = new int[m + 1, r + 1];
            int[,] c = new int[n + 1, r + 1];

            string satir1 = "", satir2 = "", satir3 = "";
            for (i = 1; i <= n; i++)
            {
                satir1="";
                for (j = 1; j <= m; j++) 
                {
                    a[i, j] = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("A[" + i + "," + j + "] elemanını giriniz", "A matrisi", "", 100, 100));
                    satir1 += a[i, j].ToString() + "   ";
                }
                listBox1.Items.Add(satir1);
            }

            for (i = 1; i <= m; i++)
            {
                satir2 = "";
                for (j = 1; j <= r; j++)
                {
                    b[i, j] = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("B[" + i + "," + j + "] elemanını giriniz", "B matrisi", "", 100, 100));
                    satir2 += b[i, j].ToString() + "   ";
                }
                listBox2.Items.Add(satir2);
            }

            for (i = 1; i <= n; i++) 
            {
                satir3 = "";
                for (j = 1; j <= r; j++)
                {
                    t = 0;
                    for (k = 1; k <= m ; k++)
                        t += a[i, k] * b[k, j];
                    c[i, j] = t;
                    satir3 += t.ToString() + "  ";
;                }
                listBox3.Items.Add(satir3);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
