using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace metinde_istenilen_harf_sayisini_hesaplama
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
            label4.Text = string.Empty; 

            string cumle = textBox1.Text;
            char harf = Char.Parse(textBox2.Text);
            int sayac = 0;

         


            foreach(char i in cumle) { 
            
            
                
                    if(i == Char.ToUpper(harf) && i == Char.ToLower(harf))
                    {

                    
                       sayac++; 
                        

                    }
                    else
                    {
                        if(Char.ToUpper(i) == Char.ToUpper(harf))
                        {

                            sayac++;
                        
                        }
                    }


               
            
            label4.Text = sayac.ToString();   
            
            
            
            }





            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
