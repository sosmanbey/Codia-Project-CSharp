using System;

namespace Sayı_Tek_mi_Çift_mi_v1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi;
            Console.Write("Sayı giriniz: ");
            sayi = Convert.ToInt32(Console.ReadLine());

            // (sayi % 5 == 0) 5e tam bölünmeyi bulma.
            if (sayi % 2 == 0)
            {
                Console.Write("Sayı çifttir.");
            }
            else
            {
                Console.Write("Sayı tektir.");
            }

            Console.ReadLine();
        }
    }
}
