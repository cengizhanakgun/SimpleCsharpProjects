using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace faktoriyelhesaplama
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

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            int sayi = Convert.ToInt32(textBox1.Text);
            int sonuc = 1;

            for (int i = sayi; i >= 1; i--)
            {
                sonuc = sonuc * i;
                if (i == 1)
                
                    label2.Text += i.ToString();

                
                else
                
                    label2.Text += i.ToString() + "x";


               
            }
            label2.Text += "=" + sonuc;
        }
    }
}
