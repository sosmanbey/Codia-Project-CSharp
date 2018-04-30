using System;

namespace Mevsim_Ayları_v2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string mevsim;
            Console.Write("Lütfen mevsimi küçük harflerle giriniz: ");
            mevsim = Console.ReadLine();

            switch (mevsim)
            {
                case "yaz": Console.Write("Yaz mevsimi ayları: Haziran-Temmuz-Ağustos");
                    break;
                case "sonbahar": Console.Write("Sonbahar mevsimi ayları: Eylül-Ekim-Kasım");
                   break;
                case "kış": Console.Write("Kış mevsimi ayları: Aralık-Ocak-Şubat");
                    break;
                case "ilkbahar":Console.Write("İlkbahar mevsimi ayları: Mart-Nisan-Mayıs");
                    break;
                default:Console.Write("Hatalı mevsim girişi.");
                    break;
            }
            Console.Read();
        }
    }
}
