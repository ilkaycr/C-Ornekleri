using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a , b ;
            a = Convert.ToInt32(textBox1.Text); // kontrol_adı.özellik
            b = Convert.ToInt32(textBox2.Text);
            int c = a + b;
            //label3.Text = c.ToString();  //veya
            //label3.Text = "Sonuç = " + Convert.ToString(c);
            label3.Text = "Sonuç = " + c; //  c'yi otomatik olarak stringe dönüştürdü
            
            
            textBox1.Text = ""; //textbox1 in içini sil
            textBox2.Text = "";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hoşgeldiniz");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label3.Text += 5; //label3.text = label3.text + 5
        }
    }
}
