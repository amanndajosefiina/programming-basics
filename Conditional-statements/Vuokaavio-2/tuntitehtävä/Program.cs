using System;

namespace tuntitehtävä
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ohjelma laskee kertoman. Anna luku, mihin saakka kerrotaan");
            string userInput = Console.ReadLine();
            int number = int.Parse(userInput);
            //int.TryParse(userInput, out int number);
            int i = 0;
            int f = 1;

            //do
            //{
            //    i = i + 1;
            //    //i++
            //    f = f * i;
            //    Console.WriteLine($" {i}! = {f}"); //5! = 120
            //} while (i < number);

            /*
                while(i < number)
                {
                i = i + 1;
                   f = f * i;
                   Console.WriteLine($" {i}! = {f}"); //5! = 120
                 }
             */

            for (int j=1; i < number; j++)
            {
                f = f * j;
                Console.WriteLine($" {i}! = {f}"); //5! = 120
            }

            Console.WriteLine($"Syotit: {number}\n Vastaus: {f}");
            Console.ReadKey();
        }
    }
}
