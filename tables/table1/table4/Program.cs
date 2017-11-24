using System;

namespace table4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma arpoo kaksiuloitteiseen taulukkoon kokonaislukuja.");
            Console.WriteLine("[X, Y] = Arvo");

            Random rnd = new Random();

            int[,] numbers = new int[10,20];

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    numbers[i,j] = rnd.Next(0, 100);
                }
            }

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    Console.WriteLine($"[{i}, {j}] = {numbers[i,j]}");
                }
            }

            Console.ReadKey();

        }
    }
}
