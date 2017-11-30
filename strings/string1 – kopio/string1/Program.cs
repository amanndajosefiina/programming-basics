using System;

namespace string1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ohjelma ilmoittaa käyttäjän syöttämästä syötteestä merkkien lukumäärän. \nKirjoita kiitos: ");
            string userInput = Console.ReadLine();

            Console.WriteLine($"Syötteessä oli {userInput.Length} merkkiä.");

            Console.ReadKey();
        }
    }
}
