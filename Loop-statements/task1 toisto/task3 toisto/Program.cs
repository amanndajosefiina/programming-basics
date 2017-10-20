using System;

namespace task3_toisto
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            Console.WriteLine("Ohjelma tulostaa 20 satunnaista lukua.");

            for (int i = 1; i <= 4; i++)
            {
                Console.Write($"Rivi {i}: ");
                for (int y = 1; y <= 5; y++)
                {
                    if (y < 5)
                        Console.Write($"{rnd.Next(50)},");
                    else
                        Console.Write($"{rnd.Next(50)} \n");
                }
            }
            Console.ReadKey();
        }
    }
}
