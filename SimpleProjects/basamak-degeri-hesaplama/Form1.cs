using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace basamak_degeri_hesaplama
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {


            int toplam = 0;

            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                string karakter = textBox1.Text[i].ToString();
                if (Char.IsNumber(Convert.ToChar(karakter)))
                {
                    toplam += Convert.ToInt32(karakter);
                }
            }
            label3.Text = toplam.ToString();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
