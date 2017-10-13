using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ohjelma laskee lukujen summan. Syötä luku  ");
            string userInput = Console.ReadLine();
            int number = int.Parse(userInput);

            int f = 0;
            int i = 0;

            if (number > 0)
            {
                do
                {
                    f = f + i;
                    i = i + 1;
                }
                while (i <= number);
            }

            else
            {
                do
                {
                    f = f + i;
                    i = i - 1;
                }
                while (i >= number);
            }
            
            Console.WriteLine($"Luvun {number} yhteenlaskettu tulos on {f}");
            Console.ReadKey();
            
           
        }
    }
}
