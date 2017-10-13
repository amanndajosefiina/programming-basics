using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ohjelma laskee annetun luvun kertoman. Anna luku: ");
            string userInput = Console.ReadLine();
            int number = int.Parse(userInput);
            int f = 1;
            int i = 1;

            if (number < 0)
            {
               Console.WriteLine("Numero jonka syötit on virheellinen.");
            }
                
            else
            {
                while (i <= number)
                {
                    f = f * i;
                    i = i + 1;
                }

                Console.WriteLine($"Luvun {number} kertoma on {f}");
            }
            Console.ReadKey();
        }
    }
}
