using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayilari_label_icerisinde_kendisi_kadar_yan_yana_yazdirma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int baslangic = Convert.ToInt32(textBox1.Text); 
            int bitis = Convert.ToInt32(textBox2.Text);

            for (int i = baslangic; i <= bitis; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    label4.Text += i.ToString();
                }
                label4.Text += "\n";
            }
        }
    }
}
