using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18.Ders_Değişken_Sayısında_Parametre_alan_metotlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //değişken sayıda parametre alan metotlar
            label1.Text = toplam(1,6,3,25).ToString(); 
        }

        int toplam(params int[] sayilar)
        {
            if (sayilar.Length == 0)
                return 0;
            int toplam = 0;
            foreach (int sayi in sayilar)
                toplam += sayi;
            return toplam;
        }
    }
}
