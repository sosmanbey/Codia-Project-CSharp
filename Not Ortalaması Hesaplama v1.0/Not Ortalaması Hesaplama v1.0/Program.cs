using System;

namespace Not_Ortalaması_Hesaplama_v1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Öğrenci Not Hesaplama");
            Console.WriteLine();
            double sinav1, sinav2, sinav3, proje, ort;
            string ad, soyad, numara;

            Console.WriteLine();
            Console.WriteLine("***Öğrenci Kimlik Bilgileri***");
            Console.WriteLine();

            Console.Write("Adınız= ");
            ad = Console.ReadLine();
            Console.Write("Soyadınız= ");
            soyad = Console.ReadLine();
            Console.Write("Numaranız= ");
            numara = Console.ReadLine();

            Console.WriteLine("**Öğrenci Sınav Bilgileri**");
            Console.WriteLine();

            Console.Write("1.sınav= ");
            sinav1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("2.sınav= ");
            sinav2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("3.sınav= ");
            sinav3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Proje= ");
            proje = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("***Ortalama Değeri***");
            ort = (sinav1 + sinav2 + sinav3 + proje) / 4;
            Console.WriteLine("AdSoyad= " + ad + " " + soyad);
            Console.WriteLine("Numara= " + numara);
            Console.WriteLine("Ortalama= " + ort);

            Console.Read();
        }
    }
}
