using System;

namespace Mevsim_Ayları_v1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string mevsim;
            Console.Write("Lüften küçük harflerle bir mevsim giriniz: ");
            mevsim = Console.ReadLine();

            if (mevsim == "kış")
            {
                Console.WriteLine("Aralık-Ocak-Şubat");
            }
            else if (mevsim == "yaz")
            {
               Console.WriteLine("Haziran-Temmuz-Ağustos");
            }
            else if (mevsim == "ilkbahar")
            {
                Console.WriteLine("Mart-Nisan-Mayıs");
            }
            else if (mevsim == "sonbahar")
            {
                Console.WriteLine("Eylül-Ekim-Kasım");
            }
            else
            {
                Console.Write("Mevsimi yanlış girdiniz");
            }
            Console.Read();
        }
    }
}
