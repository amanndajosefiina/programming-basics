using System;

namespace funktio_task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Syötä kymmenen positiivista kokonaislukua. Ohjelma palauttaa suurimman: ");
            Console.WriteLine($"{highNumber()}");

            Console.ReadKey();
        }

        static string highNumber()
        {

            string result = "";
            int i = 0;
            int max = 0;
            int line = 0;
            bool b;

            for (int y = 1; y <= 10; y++)
            {
                Console.Write($"{y}. ");
                // syötä luku

                if (b = int.TryParse(Console.ReadLine(), out i) && i > 0)
                {
                    if (max < i)
                    {
                        max = i;
                        line = y;
                    }
                }
                else
                {
                    Console.WriteLine("Syöttämäsi luku oli negatiivinen. Syötä uusi luku!");
                    y--;
                }
                result = ($"Suurin luku {max} oli rivillä {line}");
            }
            //mikä on suurin
            return result;
        }
    }
}
