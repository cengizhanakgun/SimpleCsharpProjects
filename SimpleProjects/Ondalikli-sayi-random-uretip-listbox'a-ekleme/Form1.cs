using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ondalikli_sayi_random_uretip_listbox_a_ekleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int rastgeleSayi = r.Next(1, 10);
            double ondalikliRastgelesayi = r.NextDouble();
            double uretilenSayi = rastgeleSayi + ondalikliRastgelesayi;
            textBox1.Text += uretilenSayi.ToString()+"\r\n";
        }
    }
}
