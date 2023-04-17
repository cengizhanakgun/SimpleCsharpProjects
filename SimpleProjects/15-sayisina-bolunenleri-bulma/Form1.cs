using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15_sayisina_bolunenleri_bulma
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



        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            for (int i = 0; i < 500; i++)
            {
                if(i%3==0 && i % 5 == 0)
                {
                    listBox1.Items.Add(i.ToString());   
                }
            }




        }
    }
}
