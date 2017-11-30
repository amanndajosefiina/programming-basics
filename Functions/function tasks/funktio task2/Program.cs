using System;

namespace funktio_task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma palauttaa annetuista kahdesta kahdesta luvusta pienemmän. Anna luku 1:  ");
            string userInput = Console.ReadLine();
            Console.WriteLine("Anna luku 2:   ");
            string userInput2 = Console.ReadLine();
            int luku1 = int.Parse(userInput);
            int luku2 = int.Parse(userInput2);

            int low = GetMin(luku1, luku2);

            Console.WriteLine($"Luvuista {luku1} ja {luku2} {low} on pienempi.");

            Console.ReadKey();
        }

        static int GetMin(int a, int b)
        {
            if (a > b)
                return b;
            else
                return a;
        }              
    }
}
