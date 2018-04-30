using System;

namespace Tribonacci_v1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 1;
            int c = 2;
            int d;
            Console.WriteLine(a); //bu üç satırı yazmasaydık direk
            Console.WriteLine(b); //4,7,13,24 olarak devam edecekti.
            Console.WriteLine(c); //10 elemandan oluşmuş olması için bu üç satırı da yazdık.
            for (int i = 1; i <= 7; i++)
            {
                d = a + b + c;
                a = b;
                b = c;
                c = d;
                Console.WriteLine(d);
            }
            Console.ReadKey();
        }
    }
}
