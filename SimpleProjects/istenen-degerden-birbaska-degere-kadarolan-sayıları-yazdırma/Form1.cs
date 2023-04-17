using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace istenen_degerden_birbaska_degere_kadarolan_sayıları_yazdırma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            textBox4.Text = string.Empty; 
            int baslangic = Convert.ToInt32(textBox1.Text);
            int bitis = Convert.ToInt32(textBox2.Text); 
            int artisMiktari = Convert.ToInt32(textBox3.Text);

            if(bitis > baslangic) {

                for (int i = baslangic; i <= bitis; i=i+artisMiktari)

                {

                    textBox4.Text += i.ToString() + ",";


                }


            }
            else
            {
                for (int i = baslangic; i>=bitis;i=i+artisMiktari)
                {
                    textBox4.Text += i.ToString() + ",";
                }
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
