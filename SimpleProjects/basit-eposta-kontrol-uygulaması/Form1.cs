using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace basit_eposta_kontrol_uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string stringEmail = textBox1.Text;

            int result = stringEmail.IndexOf("@");

            if (result == -1)
            {
                MessageBox.Show("Bu mail adresi doğru değildir.");

            }
            else
            {
                MessageBox.Show("@ işareti doğru pozisyonda bulundu.",result.ToString());
            }
        }
    }
}
