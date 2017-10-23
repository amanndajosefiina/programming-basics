using System;

namespace task5_toisto
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            Console.WriteLine("Ohjelma tulostaa vakioveikkauksen rivin.");

            for (int i = 1; i <= 13; i++)
            {
                double j = rnd.NextDouble();

                if (j <= 0.4)
                {
                    Console.WriteLine($"{i}. 1");
                }

                else if (j >= 0.8)
                {
                    Console.WriteLine($"{i}. X");
                }

                else
                {
                    Console.WriteLine($"{i}. 2");
                }
                
            }
            Console.ReadKey();
            
        }
    }
}
