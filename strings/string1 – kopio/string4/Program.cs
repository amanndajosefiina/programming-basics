using System;

namespace string4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma selvittää onko sana palindromi.\nKirjoita sana: ");
            string userInput = Console.ReadLine();

            string reverse = "";
            int i = userInput.Length;

            for (int j = i-1; j >= 0; j--) 
            {
                reverse = reverse + userInput[j];
            }

            if (reverse == userInput)
            {
                Console.WriteLine($"{userInput} on palindromi.");
            }
            else
            {
                Console.WriteLine($"{userInput} ei ole palindromi.");
            }

            Console.ReadKey();
        }
    }
}
