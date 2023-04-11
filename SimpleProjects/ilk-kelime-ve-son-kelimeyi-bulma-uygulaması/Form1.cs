using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ilk_kelime_ve_son_kelimeyi_bulma_uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int ilkBoslukKarakteri = textBox1.Text.IndexOf("");
            label2.Text = ilkBoslukKarakteri.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}




//int ilkBoslukKarakteri = textBox1.Text.IndexOf("");
//int sonBoslukKarakteri = textBox1.Text.LastIndexOf("");

//string ilkKelime = textBox1.Text.Substring(0, ilkBoslukKarakteri);
//string sonKelime = textBox1.Text.Substring(sonBoslukKarakteri, textBox1.Text.Length - sonBoslukKarakteri);
//label2.Text = "ilkBoslukKarakteri=" + ilkBoslukKarakteri.ToString() + "\r\nsonBoslukKarakteri=" + sonBoslukKarakteri.ToString() + "\r\nilkKelime=" + ilkKelime + "\r\nsonKelime=" + sonKelime;