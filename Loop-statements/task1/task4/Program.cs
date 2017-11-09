using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjelma laskee syötetyn luvun parittomat ja parilliset luvut yhteen. Syötä luku: ");
            string userInput = Console.ReadLine();
            int number = int.Parse(userInput);

            int i = 1;
            int y = -1;
            int parilliset = 0;
            int parittomat = 0;

            if (number > 0)
            {
                for (i = 1; i <= number; i++)
                {
                    if (i % 2 == 0)
                    {
                        parilliset = parilliset + i;
                    }
                    else
                    {
                        parittomat = parittomat + i;
                    }
                }
            }
            else
            {
                for (y = -1; y >= number; y--)
                {

                    if (y % -2 == 0)
                    {
                        parilliset = parilliset + y;
                    }
                    else
                    {
                        parittomat = parittomat + y;
                    }
                }
            }
           
            Console.WriteLine($"luvun {number} parillisten ja parittomien summat ovat {parilliset} ja {parittomat} ");
            Console.ReadKey();
        }
    }
}
