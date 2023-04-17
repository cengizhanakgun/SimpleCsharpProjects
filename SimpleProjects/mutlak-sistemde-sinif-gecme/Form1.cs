using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mutlak_sistemde_sinif_gecme
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "") return;

            double vize = Convert.ToDouble(textBox1.Text);
            double final = Convert.ToDouble(textBox2.Text);

            double gecmeNotu = (vize * 40 / 100) + (final * 60 / 100);

            label3.Text = gecmeNotu.ToString();
        }
    }
}
