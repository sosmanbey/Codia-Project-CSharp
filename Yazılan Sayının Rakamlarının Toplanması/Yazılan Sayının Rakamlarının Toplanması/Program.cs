using System;

namespace Yazılan_Sayının_Rakamlarının_Toplanması
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi, sonuc, rakam;
            int sıfır = 0;
            Console.Write("Sayıyı giriniz: ");
            sayi = Convert.ToInt32(Console.ReadLine());

            sonuc = sayi.ToString().Length;
            for (int i = 0; i < sonuc; i++)
            {
                rakam = int.Parse(sayi.ToString().Substring(i, 1));
                sıfır = rakam + sıfır;
            }
            Console.WriteLine("Girilen sayının rakamları toplamı= " + sıfır);

            Console.ReadKey();
        }
    }
}
