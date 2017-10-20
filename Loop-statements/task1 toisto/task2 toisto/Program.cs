using System;

namespace task2_toisto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa numeroiden 1-9 kertotaulut.");

            int luku = 1;
            int summa;
            int kertoja = 1;

            while (luku <= 9)
            {
                while (kertoja <= 10)
                {
                    summa = luku * kertoja;
                    Console.WriteLine($"{luku}*{kertoja} = {summa}");
                    kertoja = kertoja + 1;
                }

                luku = luku + 1;
                kertoja = 1;
            }



            Console.ReadKey();

        }
    }
}
