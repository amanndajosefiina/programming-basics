using System;

namespace funktio_task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Funktio palauttaa annetun määrän tähtiä, jotka pääohjelma tulostaa näytölle. Anna luku:  ");
            string userInput = Console.ReadLine();

            Console.WriteLine($"{GetStars(userInput)}");

            Console.ReadKey();
        }

        static string GetStars(string numberOfStars)
        {
            int number = int.Parse(numberOfStars);
            string printStars = "";

            if (number <= 0)
                return "Antamasi luku on virheellinen. Syötä positiivia lukuja.";

            for (int i = 0; i < number; i++)
            {
                printStars += "*"; //printStars = printStars + "*"
            }
            return printStars;

        }

    }
}
