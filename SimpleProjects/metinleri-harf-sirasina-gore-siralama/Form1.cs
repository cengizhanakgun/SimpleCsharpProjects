using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace metinleri_harf_sirasina_gore_siralama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            textBox1.Text = string.Empty;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] metinler = new string[listBox1.Items.Count];
            for (int i = 0; i < listBox1.Items.Count; i++)
            
                metinler[i] = listBox1.Items[i].ToString();

            Array.Sort(metinler);   
            listBox1.Items.Clear(); 

            if (comboBox1.SelectedIndex == 0) {
                for (int i = 0; i < metinler.Length; i++)
                {
                    listBox1.Items.Add(metinler[i]);    

                }
            }
            else
            {
                for (int i = metinler.Length - 1; i > -1; i--) 
                {
                    listBox1.Items.Add(metinler[i]);
                       
                }
            }

        }
    }
}
