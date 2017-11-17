using System;

namespace itsearviointitehtävä
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Minäpä tiedän luvun väliltä 1-100, jota sinä et tiedä!");

            Random rnd = new Random();
            int rightNumber = rnd.Next(0, 100);

            do
            {
                string userInput = Console.ReadLine();
                int number = int.Parse(userInput);

                if (rightNumber > number)
                {
                    Console.WriteLine("Lukusi on liian pieni. Arvaa uudestaan!");
                }

                else if (rightNumber < number)
                {
                    Console.WriteLine("Lukusi on liian suuri. Arvaa uudestaan!");
                }
                else
                {
                    Console.WriteLine("Arvasit oikein! Onneksi olkoon.");
                }
            }
            while (true);

            Console.ReadKey();

        }
    }
}
