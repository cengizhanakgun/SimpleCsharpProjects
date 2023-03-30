using System;

namespace Stringformatlama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fiyat = 119;
            int kdv = 18;
            string yMetin = String.Format("Fiyatı: {0}", fiyat);
            Console.WriteLine(yMetin);


            /// Birden fazla değişkenin kullanılması söz konusu
            /// 

            Console.WriteLine(String.Format("Ürünün {0} Fiyatına ek kdvsi % {1} kadardır. ",fiyat,kdv));
        }
    }
}
