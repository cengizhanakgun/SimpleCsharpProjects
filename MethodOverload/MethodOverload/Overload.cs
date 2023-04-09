using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverload
{
    public static class Overload
    {
        public static int Toplama(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
     
        public static string Toplama(string sayi1, string sayi2)
        {
            return sayi1 +" "+ sayi2;
        }
        public static double Toplama(double sayi1, double sayi2)
        {
            return sayi1 + sayi2;
        }




    }
}
