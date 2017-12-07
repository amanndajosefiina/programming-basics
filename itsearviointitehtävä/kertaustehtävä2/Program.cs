using System;

namespace kertaustehtävä2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Syötä sana tai lause: ");
            string userInput = Console.ReadLine();

            for (int i = 0; i < userInput.Length; i++)
            {
                Console.WriteLine($"{i}. {userInput}");
            }

            Console.ReadKey();

        }
    }
}
