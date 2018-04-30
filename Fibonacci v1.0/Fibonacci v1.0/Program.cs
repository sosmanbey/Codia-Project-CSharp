using System;

namespace Fibonacci_v1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 1;
            int c;
            Console.WriteLine(a); //bu iki satırı yazmasaydık direk
            Console.WriteLine(b); //2,3,5,8 olarak devam edecekti.10 elemandan oluşmuş olması için.
            for (int i = 1; i <= 8; i++)
            {
                c = a + b;
                a = b;
                b = c;
                Console.WriteLine(c);
            }
            Console.ReadKey();
        }
    }
}
