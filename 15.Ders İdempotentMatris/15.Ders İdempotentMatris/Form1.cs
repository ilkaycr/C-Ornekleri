using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15.Ders_İdempotentMatris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i, j, k, n, p = 1 ; 
            double t = 0;
            bool kontrol;
            string satir = "";
            n = int.Parse(textBox1.Text);
            double[,] a = new double[n + 1, n + 1];
            double[,] b = new double[n + 1, n + 1];

            for (i = 1; i <= n; i++) 
                for (j = 1; j <= n; j++)  
                    a[i, j] = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("A[" + i + "," + j + "].elemanı giriniz", "A Matrisi", "", 100, 100));

            for (i = 1; i <= n; i++) 
                for (j = 1; j <= n; j++) 
                {
                    t = 0;
                    for (k = 1; k <= n; k++) 
                        t += (a[i, k] * a[k, j]);
                    b[i, j] = t;
                }   
            
            kontrol = true;
            for ( i = 1; i <= n; i++)
                for ( j = 1; j <= n; j++)
                    if (b[i, j] != a[i, j])
                        kontrol = false;


            
            if (kontrol = true)
                label3.Text = "Matris İdempotentdir";
            else
                label3.Text = "Matris İdempotent değildir";

            for (i = 1; i <= n; i++)
            {
                satir = "";
                for (j = 1; j <= n; j++)
                    satir += b[i, j].ToString + "   ";
                listBox1.Items.Add(satir);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
