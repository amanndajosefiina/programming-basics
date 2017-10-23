using System;

namespace task6_toisto
{
    class Program
    {
        static void Main(string[] args)
        {
            int kutoset = 0;

            Random rnd = new Random();
            Console.WriteLine("Ohjelma simuloi nopan heittoa ja näyttää luvun 6 määrän.");

            for (int i = 1; i <= 1000; i++)
            {
                int luku = rnd.Next(6)+1;
                Console.WriteLine($"{i}. {luku}");

                if (luku == 6)
                    kutoset++;
            }
            Console.WriteLine($"Kutosten määrä on numeroiden joukossa on {kutoset}.");


            Console.ReadKey();


        }
    }
}
