using System;

namespace table3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma arpoo taulukkoon kokonaislukuja.");
            Console.WriteLine("[X] = Arvo");

            Random rnd = new Random();

            int[] numbers = new int[10];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(0, 20);
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"[{i}] = {numbers[i]:00}");
            }

            Console.ReadKey();
        }
    }
}
