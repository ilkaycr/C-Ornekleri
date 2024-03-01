using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5.DersUygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //tür dönüşümü
            // 1) bilinçli tür dönüşümü
            // 2) bilinçsiz tür dönüşümü

            // 1 bilinçsiz tür dönüşümü
            int a = 51;
            long b; // daha büyük değerleri tutabilir long  8 byte int 4 byte
            b = a;  // b nin türü neyse a nın türü de olması gerekiyor otomatik olarak yapıyor bu da bilinçsiz dönüşüm oluyor
            a = 90; // burda a nın türü neyse öyle devam eder yani int
            //a = b; // düşükten büyüğe yani 4 byte dan 8 byte a çıkamayız ..



            // 2 bilinçli tür dönüşümü
            // derleyecinin izin vermediği dönüşümlerde kullanılır . Genellikle büyük türü küçük türe dönüştürürken kullanılır.(Veri kayıpları olabilir)
            byte f = 6;
            int g = 9;
            f = (byte)g;
            label2.Text = f.ToString(); // eğer g ye 255 üzeri bir değer atarsak veri kaybı yaşanır çünkü byte maksimim 255 değerini alabilir

        }



        private void button3_Click(object sender, EventArgs e)
        {
            
            //-------BİLİNÇSİZ------
            byte a = 5;
            int b;
            b = a;
            float c = 7.9f;
            double d;
            d = c;
            // c = d; // küçükten büyüğe olmaz
            char x = 's';
            decimal y; // onluk sayı sistemi
            y = x;
            label1.Text = y.ToString();
            
        }
        private void button4_Click(object sender, EventArgs e)
        {
            //------BİLİNÇLİ------
            double a = 7.6;
            float b = 7.9f;
            b =(float)a;
            label3.Text = b.ToString();
            // checked ve unchecked anahtar sözcükleri ((--Bilinçli tür  dönüşümü yaparken veri kaybı varsa uyarı almak istersek checked kullanmamız gerekir.--))
            int c = 256;
            byte d ;
            d = (byte)c;
            label4.Text = d.ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }


    }
}
