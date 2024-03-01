using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20.Ders_2.dönem_başlangıç_STRİNGler
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

        private void button1_Click(object sender, EventArgs e)
        {
            //string işlemleri

            //string cümle = "           MERhabaLAR aWQ  kelleri            ";


            // ToLower()       büyük harfleri ufak yapar
            //             textBox1.Text = cümle.ToLower();

            // ToUpper()       ufakları büyütür
            //             textBox1.Text = cümle.ToUpper();

            // Replace()       bir string ifadede istenilen bir değeri farklı bir değer ile değiştirmek için kullanılır
            //             textBox1.Text = cümle.Replace("aWQ","AMk");

            // Trim()          bir string ifadenin başındaki ve sonundaki boşlukları silmek için kullanılır
            //             textBox1.Text = cümle.Trim();

            // TrimStart()     bir string ifadenin başındaki boşlukları silmek için kullanılır
            // TrimEnd()       bir string ifadenin sonundaki boşlukları silmek için kullanılır

            // StartsWith()    bir cümlenin "blabla" ile başlıyor mu
            //             textBox1.Text = Convert.ToString(cümle.StartsWith("MERhabaLAR"));   false çıkar çünkü cümle boşlukla başlıyor
            //             textBox1.Text = Convert.ToString(cümle.Trim.StartsWith("MERhabaLAR")); şimdi True çıkar çünkü Trim i öğrendik
            // EndsWith()      bir cümlenin "blabla" ile bitiyor mu 

            // Contains()    bir string ifadenin içinde farklı bir ifade var mı diye kontrol etmek için kullanılır 
            //             textBox1.Text = Convert.ToString(cümle.Contains("bana");

            // Remove()      indisten istenilen kadar karakter silmek için kullanılır
            //             textBox1.Text = cümle.Remove(0, 15);

            string cumle = "www.kudurdum.net";

            // Split()      *önemli* bir string ifadeyi istenilen bir karakteri kullanarak bölmek için kullanılır
            //             textBox1.Text = cumle.Split('.')[1];

            // İndekxOf()    kaçıncı indis olduğunu verir
            //             textBox1.Text = cumle.IndexOf("dum").ToString();

            // PadLeft()     cümleyi girilen karaktere tamamlar cümlenin soluna boşluk ekler (70,s) yaparsak s ile tamamlar
            //             textBox1.Text = cumle.PadLeft(70);
            // PadRight()    cümleyi girilen karaktere tamamlar cümlenin soluna boşluk ekler (70,s) yaparsak s ile tamamlar

            // SubString()    *önemli*  bir string ifadeden istenilen indisten itibaren istenilen kadar karakter almak için kullanılır
            //            textBox1.Text = cumle.Substring(3, 5);
            //            textBox1.Text = cumle.Substring(4);  //4. indisten itibaren hepsini al

            // Join()
            string[] a = { "dost", "most", "tost" };
            //            textBox1.Text = string.Join(";", a);  // a nesnesini dizisini ; ile birleştir  
            //            textBox1.Text = a[0] + ";" + a[1] .... gibi de yapılabilir

            // Girilen bir cümledeki a karakterinin sayısını bulan bir visual c# programı yapalım çözümü 21. ders dosyasında






        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
