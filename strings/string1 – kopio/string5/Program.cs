using System;

namespace string5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma laskee vokaalit. Kirjoita sana:");
            string userInput = Console.ReadLine();

            int count = 0;

            foreach (char ch in userInput)
            {

                if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'u' || ch == 'ä' || ch == 'ö')
                {
                    count++;
                }

            }

            Console.WriteLine($"Vokaalien määrä sanassa on {count}.");

            Console.ReadKey();
        }
    }
}
