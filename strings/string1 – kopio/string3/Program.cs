using System;

namespace string3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma muuttaa käyttäjän syöttämästä syötteestä L-kirjaimet. \nKirjoita sana: ");
            string userInput = Console.ReadLine();

            int count = 0;

            foreach (char ch in userInput)
            {
                if (ch == 'l' || ch == 'L')
                {
                    count++;
                }

            }

            Console.WriteLine($"L-kirjaimia oli {count}.");

            Console.ReadKey();

        }
    }
}
