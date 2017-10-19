using System;

namespace task1_toisto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa kokonaisluvut 1-10 ja niiden neliöjuuret.");

            int luku = 1;
            double neliö;

            while (luku <= 10)
            {
                neliö = Math.Round(Math.Sqrt(luku), 2);
                Console.WriteLine($"Luku {luku} neliöjuuri {neliö}");
                luku = luku + 1;                
            }


            Console.ReadKey();                   
        }
    }
}
