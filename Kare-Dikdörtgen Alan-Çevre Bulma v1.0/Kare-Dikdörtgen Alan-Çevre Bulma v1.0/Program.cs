using System;

namespace Kare_Dikdörtgen_Alan_Çevre_Bulma_v1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int kenar, karealan, karecevre;
            int kısakenar, uzunkenar, dikalan, dikcevre;

            Console.WriteLine("*****Karenin Alan ve Çevresini Bulma*****");
            Console.WriteLine();
            Console.Write("Kenar uzunluğunu giriniz= ");
            kenar = Convert.ToInt32(Console.ReadLine());
            karealan = kenar * kenar;
            karecevre = kenar * 4;
            Console.WriteLine();
            Console.WriteLine("Karenin Alanı= " + karealan);
            Console.WriteLine("Karenin Çevresi= " + karecevre);
            Console.WriteLine();

            Console.WriteLine("*****Dikdörtgenin Alan ve Çevresini Bulma*****");
            Console.WriteLine();

            Console.Write("Kısa kenarı girin= ");
            kısakenar = Convert.ToInt32(Console.ReadLine());
            Console.Write("Uzun kenarı girin= ");
            uzunkenar = Convert.ToInt32(Console.ReadLine());
            dikalan = kısakenar * uzunkenar;
            dikcevre = (kısakenar * 2) + (uzunkenar * 2);
            Console.WriteLine();
            Console.WriteLine("Dikdörtgenin Alanı= " + dikalan);
            Console.WriteLine("Dikdörtgenin Çevresi= " + dikcevre);


            Console.Read();
        }
    }
}
