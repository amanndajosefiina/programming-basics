using System;

namespace funktio_task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna luku väliltä 10-20: ");
            int lower = 10;
            int upper = 20;

            Console.WriteLine($"Syötit oikean luvun {retNumber(lower, upper)}");

            Console.ReadKey();

        }

        static int retNumber(int lower, int upper)

        {
            string userInput = Console.ReadLine();
            int number = int.Parse(userInput);

            do
            {

                if (number < 10 || number > 20)
                {
                    Console.WriteLine("Syöttämäsi luku on virheellinen. Syötä uusi luku.");
                    userInput = Console.ReadLine();
                    number = int.Parse(userInput);
                }
                else
                {
                    break;
                }

            } while (true);

            return number;

        }       
    }
}
