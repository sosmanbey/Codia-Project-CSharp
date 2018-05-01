using System;

namespace Araba_Park_Süresi
{
    class Program
    {
        static void Main(string[] args)
        {
            int süre;
            Console.Write("Süreyi giriniz: ");
            süre = Convert.ToInt32(Console.ReadLine());
            if (süre > 0 && süre <= 2)
            {
                Console.WriteLine("Ücret 5TL");
            }
            else if (süre > 2 && süre <= 5)
            {
                Console.WriteLine("Ücret 10TL");
            }
            else if (süre > 5 && süre <= 12)
            {
                Console.WriteLine("Ücret 20TL");
            }
            else if (süre > 12 && süre <= 24)
            {
                Console.WriteLine("Ücret 30TL");
            }
            else
            {
                Console.WriteLine("Senelik abonemizin aylık ücreti 750TL");
            }






            Console.Read();
        }
    }
}
