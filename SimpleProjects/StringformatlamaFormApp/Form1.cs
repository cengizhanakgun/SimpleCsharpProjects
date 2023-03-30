using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringformatlamaFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayi = Convert.ToDouble(textBox1.Text);

            if (C1.Checked)

                frmatliHali.Text = String.Format("{0:C1}", sayi);
            else if (C2.Checked)
                frmatliHali.Text = String.Format("{0:C2}", sayi);
            else if (C3.Checked)
                frmatliHali.Text = String.Format("{0:C3}", sayi);
            else if (C4.Checked)
                frmatliHali.Text = String.Format("{0:C4}", sayi);
            else if (D3.Checked)
                frmatliHali.Text = String.Format("{0:D3}", sayi.ToString());
            else if (D5.Checked)
                frmatliHali.Text = String.Format("{0:D5}", sayi.ToString());
            else if (F1.Checked)
                frmatliHali.Text = String.Format("{0:F1}", sayi);
            else if (F2.Checked)
                frmatliHali.Text = String.Format("{0:F2}", sayi);
            else if (F3.Checked)
                frmatliHali.Text = String.Format("{0:F3}", sayi);
            else if (N.Checked)
                frmatliHali.Text = String.Format("{0:N}", sayi);
            else if (X.Checked)
                frmatliHali.Text = String.Format("{0:X}", sayi);
            else if (E.Checked)
                frmatliHali.Text = String.Format("{0:E}", sayi);
            else if (rbDiyez.Checked)
                frmatliHali.Text = String.Format("{0:###.##}", sayi);
            else if (rb0.Checked)
                frmatliHali.Text = String.Format("{0:000000.00}", sayi);
            else frmatliHali.Text = "Herhangi bir format seçilmedi";
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
