using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12.DersUygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] a = new int[100]; //veya

            int[] a1;
            a1 = new int[100];          //biz bir şey vermezsek aşağıdaki gibi alır
            //sayısal türler için 0
            //referans türler için null
            //bool türler için false
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] a = new int[10];
            for (int i= 0; i <= 9 ; i++)
            {
                listBox1.Items.Add(a[i]);
            }

            bool[] b = new bool[10];
            for (int i = 0; i < 9; i++)
            {
                listBox2.Items.Add(b[i]);
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int[] a = { 12, 34, 67, 89, 90 };
            string[] b = { "ali", "ayşe", "ahmet", "fatma" };
            double[] c = { 2, 3, 4, 5, 5.6f };
            float[] d = { 2.3f, 5.21f, 53.5f };

            //iki boyutlu diziler
            //tür[,] dizi_adı=new tür[boyut1,boyut2];
            int[,] x = new int[3, 4];
            // x[0,0],x[0,1],x[0,2],x[0,3]
            // x[1,0],x[1,1],x[1,2],x[1,3]
            // x[2,0],x[2,1],x[2,2],x[2,3]

            int[,] xx = { { 1, 2, 3 }, { 6, 8, 9 } };
            string satir = "";
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    satir += xx[i, j]+"  "; //satir = satir + a[i,j]
                // satir = 123
                }
                listBox3.Items.Add(satir);
                satir = "";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox4.Items.Clear();
            Random r = new Random();
            int[,] a = new int[3, 4];
            for (int i = 0; i<2;i++)
                for (int j = 0; j < 3; j++)
                {
                    a[i, j] = r.Next(50);    // random sınıfının next metodu rastgele sayı üretir (50) yzmamız 0 ile 50 arasında bir sayı üret demektir (1,5) yazsak 1 ile 5 arasında üretir.

                }

            string satir = "";
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    satir += a[i, j] + "  "; //satir = satir + a[i,j]
                                              // satir = 123
                }
                listBox4.Items.Add(satir);
                satir = "";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            /*Örnek:
             *Girilen n tane sayıyı bir diziye atayıp bu dizinin elemanlarını toplayan bir C# programı yazınız.
            */
            listBox5.Items.Clear();
            if (textBox1.Text != "")
            {
                int n = Convert.ToInt32(textBox1.Text);
                int[] a = new int[n];
                int i, toplam = 0;
                for (i = 0; i < n; i++)
                {
                    a[i] = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox(i+1+".elemanlar", "girdi", "", 100, 100));
                    listBox5.Items.Add(a[i]);
                    toplam += a[i];
                }
                label2.Text = toplam.ToString();
            }
            else
                label2.Text = "lütfen n yi giriniz";

                        

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
