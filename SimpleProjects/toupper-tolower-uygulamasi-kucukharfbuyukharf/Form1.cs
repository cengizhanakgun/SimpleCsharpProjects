using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace toupper_tolower_uygulamasi_kucukharfbuyukharf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int uzunluk = textBox1.Text.Length;
            string yeniIfade = "";
            for (int i = 0; i < uzunluk; i++)
            {
                if (Char.IsLower(textBox1.Text[i]) == true)
                    yeniIfade += textBox1.Text[i].ToString().ToUpper();
                else
                    yeniIfade += textBox1.Text[i].ToString().ToLower();

                    
                    
            }
            label2.Text = yeniIfade;    

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
