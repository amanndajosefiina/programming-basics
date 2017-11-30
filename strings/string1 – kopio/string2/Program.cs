using System;

namespace string2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma muuttaa käyttäjän syöttämästä syötteestä e kirjaimet @ merkiksi. \nKirjoita sana:");
            string userInput = Console.ReadLine();

            userInput = userInput.Replace("e", "@");
            Console.WriteLine(userInput);

            Console.ReadKey();

        }
    }
}
