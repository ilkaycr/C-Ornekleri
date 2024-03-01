using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18.Ders_Metot_parametresi_diziler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //metot parametresi olarak diziler
            int[] dizi = { 5, 7, 9, 2 };
            yaz(dizi);
        }
        
        void yaz(int[] dizi)    // int[] yazdığımız için dizi olduğunu algılıyor
        {
            foreach (int i in dizi)
                listBox1.Items.Add(i);
        }
    }
}
