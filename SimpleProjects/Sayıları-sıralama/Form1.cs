using System;
using System.Windows.Forms;

namespace Sayıları_sıralama
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

        private void button1_Click(object sender, EventArgs e)
        {
      
            string[] satirlar = richTextBox1.Text.Split('\n');
            int[] sayilar = new int[satirlar.Length];
            for (int i = 1; i < satirlar.Length; i++)
            {
                sayilar[i] = Convert.ToInt32(satirlar[i]);
            

            }
            Array.Sort(sayilar);
            richTextBox1.Text = string.Empty;

            foreach (var sayi in sayilar)
            {
                richTextBox1.Text += sayi.ToString() + "\r\n";

            }
            RemoveStringAll(satirlar);
            Array.Clear(sayilar, 1, satirlar.Length);







        }
    
        public static void RemoveStringAll(string[] numbers)
        {
            foreach (string item in numbers)
            {
                item.Remove(numbers.Length);
            }

        }
    }
}
