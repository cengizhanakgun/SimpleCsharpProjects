using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.Management.Instrumentation;
using System.ComponentModel;
using System.Data;
using System.Drawing;




namespace cputemp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //şunu indiriniz. managmentobjectsearcher hatasını giderebilmek için gereklidir.
            /////https://www.microsoft.com/en-us/download/details.aspx?id=8572
            ///console uygulamasını yönetici olarak çalıştırınız.

            ManagementObjectSearcher mos = new ManagementObjectSearcher("Select * from Win32_Process");
            foreach (ManagementObject mo in mos.Get())
            {
                Console.WriteLine("Process : {0}", mo["Name"]);
            }
            Console.ReadLine(); 
        }
    }
}
