using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayılar = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write((i + 1).ToString() + ". Sayıyı giriniz: ");
                sayılar[i] =Convert.ToInt32(Console.ReadLine());
            }
            int enbuyuk;
            enbuyuk = sayılar[0];
            for (int i = 1; i < 5; i++) //0. index kendisi olduğu için i=1 den başladık.
            {
                if (enbuyuk < sayılar[i])
                {
                    enbuyuk = sayılar[i];
                }
            }
            Console.Write(enbuyuk);
            Console.Read();
        }
    }
}
