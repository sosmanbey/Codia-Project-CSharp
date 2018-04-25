using System;

namespace Faktöriyel_Hesaplama
{
    class Program
    {
        static double faktoriyel(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            return n * faktoriyel(n - 1);
        }
        static void Main(string[] args)
        {
            Console.Write("Sayı Giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi > 0)
            {
                double sonuc = faktoriyel(sayi);
                Console.WriteLine("{0}!={1}", sayi, sonuc);
            }
            Console.ReadKey();
        }
    }
}
