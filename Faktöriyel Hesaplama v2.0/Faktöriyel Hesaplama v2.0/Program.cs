using System;

namespace Faktöriyel_Hesaplama_v2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi;
            int factoriel = 1;
            Console.Write("Faktöriyeli alınacak sayıyı giriniz: ");
            sayi = Convert.ToInt32(Console.ReadLine());
            int[] sayilar = { sayi };
            foreach (int i in sayilar)
            {
                for (int j = sayi; j > 0; j--)
                {
                    factoriel *= j;
                }
            }
            Console.WriteLine("Faktöriyel: " + factoriel);



            Console.Read();
        }
    }
}
