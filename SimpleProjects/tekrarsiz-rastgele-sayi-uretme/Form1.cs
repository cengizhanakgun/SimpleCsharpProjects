using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tekrarsiz_rastgele_sayi_uretme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Clear();
                int uretilecekSayiAdedi = Convert.ToInt32(textBox1.Text);
                int baslangic = Convert.ToInt32(textBox2.Text);
                int bitis = Convert.ToInt32(textBox3.Text);
                ArrayList list = new ArrayList();
                Random r = new Random();
                while (true)
                {

                    uretilecekSayiAdedi--;
                    int sayi = r.Next(baslangic, bitis);
                    if (list.IndexOf(sayi) != -1)
                    {
                        continue;

                    }
                    else
                    {
                        list.Add(sayi);
                        listBox1.Items.Add(sayi.ToString());

                    }
                    if (uretilecekSayiAdedi == 0)
                    {
                        MessageBox.Show("Üretilecek sayı adedi sıfır olamaz.");
                        Application.Restart();

                    }


                }


                
            }catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
              Application.Restart();
            }
    }
    }
}
