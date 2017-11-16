using System;

namespace table1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Taulukko 1");

            int[] numbers = new int[100];
            Random rnd = new Random();
            int sum = 0;

            for (int i = 0; i < 100; i++)
            {
                numbers[i] = rnd.Next(0, 51);
            }

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine($"{i+1}. {numbers[i]}");
            }

            for (int i = 0; i < 100; i++)
            {
                sum += numbers[i];
            }

            Console.WriteLine($"Lukujen summa on {sum}");
            Console.WriteLine($"Lukujen keskiarvo on {sum/100.0}");

            Console.ReadKey();

        }
    }
}
