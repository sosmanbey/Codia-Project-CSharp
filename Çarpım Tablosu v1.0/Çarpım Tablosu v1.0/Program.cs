using System;

namespace Çarpım_Tablosu_v1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.Write("İlk sayıyı giriniz: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("İkinci sayıyı giriniz: ");
            b = Convert.ToInt32(Console.ReadLine());
            c = a * b;
            Console.WriteLine("Çarpım: " + c);
            Console.ReadKey();
        }
        
    }
}
