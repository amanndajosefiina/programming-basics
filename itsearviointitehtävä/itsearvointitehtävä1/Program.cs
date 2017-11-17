using System;

namespace itsearvointitehtävä1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Syötä lukuja: ");

            int i = 0;
            int sum = 0;
            int number = 0;
            int lastNumber = -3333333;
            do
            {
                string userInput = Console.ReadLine();
                number = int.Parse(userInput);

                if (number != lastNumber)
                {
                    lastNumber = number;
                    sum = sum + number;
                }
                else
                {
                    break;
                }

            } while (true);

            Console.WriteLine($"Lukujen summa on {sum}.");

            Console.ReadKey();
        }
    }
}
