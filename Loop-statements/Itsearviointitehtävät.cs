using System;

namespace itsearviointi2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ohjelma tulostaa sanan niin monta kertaa kuin sanassa on kirjaimia. Syötä sana: ");
            string userInput = Console.ReadLine();

               for (int i = 1; i <= userInput.Length; i++)
            {
                Console.WriteLine($"{i}. {userInput}");
            }
          
            Console.ReadKey();
        }
    }
}
