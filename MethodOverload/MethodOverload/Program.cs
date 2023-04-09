using MethodOverload;
using System;

Random rnd = new Random();

List<int>_dizi=new List<int>();
_dizi.Add(rnd.Next(100));

foreach (int i in _dizi)
{

    Console.WriteLine(i);
}

List<string> o = new List<string>()
{
    "Ahmet",
    "Mamet",
    "Oguzhan",
    "Düşman"
};

var list = o.FirstOrDefault(x => x.Equals("Cengiz"));
if (list != null)
    Console.WriteLine(list);
else Console.WriteLine("Malesef Data Yok");
Console.ReadLine();

