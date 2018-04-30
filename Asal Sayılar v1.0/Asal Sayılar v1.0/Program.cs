using System;

namespace Asal_Sayılar_v1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            //30'a kadar olan asal sayılar
            int s;
            for (int i = 2; i < 30; i++)
            {
                s = 0;
                for (int j = 1; j < 30; j++)
                {
                    if (i % j == 0)
                    {
                        s += 1;
                    }
                }
                if (s == 2)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
