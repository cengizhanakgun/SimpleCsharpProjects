using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace list_icerisindeki_sayıların_toplamını_alan_uygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);  
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double toplam = 0;
            double ortalama = 0;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                toplam += Convert.ToInt32(listBox1.Items[i]);

            }
            ortalama = toplam / listBox1.Items.Count;
            label4.Text = toplam.ToString();    
            label5.Text = ortalama.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();


        }
    }
}
