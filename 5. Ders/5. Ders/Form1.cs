using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5.Ders
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int a = 4; //stack
            //referans tipler heap        
            //stack değer tipleri burda saklanır
            //referans türleri ::   string object
            // --- string veri türü ---
            //       unicode
            string b = " günaydın ";  // "string "  'karakter'
            string c = "arkadaşlar";
            string d = b + "  " + c;
            label1.Text = d;
            string dosyayolu = "c:\\ornek\\na.txt"; // 2 tane "\\" koymamızın nedeni \n yazınca alt satıra atmasın diye ya da başına @ de atabiliriz örnek = dosyayolu = @"c:\\ornek\\na.txt"             
            //  --- object veri türü --- 
            // nesnelerin obje türüne dönüştürülmesine  boxing denir örnek ;;
            object a;
            a = 55;
            label2.Text = a.GetType().ToString();
            // single  ==  float aynı anlama geliyor

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
