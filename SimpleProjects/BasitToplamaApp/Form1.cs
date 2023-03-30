using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasitToplamaApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //basit toplama
           int sayi1 = Convert.ToInt32(textBox1.Text);
           int sayi2 = Convert.ToInt32(textBox2.Text);
            int sonuc = sayi1 + sayi2;
            label1.Text = Convert.ToString(sonuc);    

        }
    }
}
