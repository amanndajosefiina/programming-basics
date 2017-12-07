using System;

namespace kertaustehtävä
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Syötä sana tai lause: ");
            string userInput = Console.ReadLine();

            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine($"{i}. {userInput}");
            }

            Console.ReadKey();
        }
    }
}
