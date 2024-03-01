using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6.DersUygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //  + - * / % ++ -- 
            int a = 7, b = 6;
            label1.Text = (a % b).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox1.Text);
            double toplam;
            if (sayi % 2 == 0)
                toplam = Math.Pow(sayi, 2); // Math.Pow kare almak
            else
                toplam = Math.Pow(sayi, 3);
            label2.Text = "Sonuç = " + ' ' + toplam;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // ++ -- sayıyı bir arttır veya bir azalt
            int a = Convert.ToInt32(textBox2.Text);
            a++; // a = a+1 veya 
            // b = ++a ; yapılabilir .  b = a++ yapmamamızın nedeni önce a yı  b ye atayıp sonra a yı 1 arttırdığı için.
            label3.Text = a.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // < , > , <= , >= , == , !=
            if (2 == 3)             // == eşit mi  != eşit değil mi
                label4.Text = "Günaydın Arkadaşlar";
            // || veya , && ve
            //  ---- atama ve işlemli atama operatörleri -----
            // = , *= , /= , %= , += , -= ,

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int b = 2;
            string a = "4";
            //a %= b; //a = a%b;
            // ?: 
            // koşul?doğru_değer:yanlış_değer
            a = a + (b == 2 ? "örnek" : "günaydın");
            label5.Text = a.ToString();
            // () [] 
            // new -- sınfılardan nesne türetmek için
        }
    }
}
