using System;

namespace task4_toisto
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.WriteLine("Ohjelma simuloi rahan heittoa.");
            string userInput = Console.ReadLine();
            int number = int.Parse(userInput);
            int heads = 0;
            int tails = 0;
            
            Console.WriteLine($"Rahaa on heitetty {number} kertaa.");

            for (int i = 0; i < number; i++) 
            {
                if (rnd.Next(2) == 0)
                    heads++;
                else
                    tails++;
            }

                Console.Write($"Klaavoja tuli {tails} ja kruunia {heads}");

            Console.ReadKey();
  
        }
    }
}
