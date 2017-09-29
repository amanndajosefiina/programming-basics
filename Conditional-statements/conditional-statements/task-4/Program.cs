using System;

namespace task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Ohjelma asettaa syötetyt numerot suuruusjärjestykseen");

            Console.WriteLine("Syötä numero 1:");
            string numero1 = Console.ReadLine();
            int numx = int.Parse(numero1);

            Console.WriteLine("Syötä numero 2:");
            string numero2 = Console.ReadLine();
            int numy = int.Parse(numero2);

            Console.WriteLine("Syötä numero 3:");
            string numero3 = Console.ReadLine();
            int numz = int.Parse(numero3);

            if (numx < numy)
            {
                if (numy < numz)
                {
                    if (numx < numz)
                    {
                        Console.WriteLine($"Järjestys on: {numx}, {numy}, {numz}");
                    }

                    else
                    {
                        Console.WriteLine($"Järjestys on: {numz}, {numx}, {numy}");
                    }
                }

                else
                {
                    Console.WriteLine($"Järjestys on: {numx}, {numy}, {numz}");
                }
            }

            else
            {
                if (numx < numz)
                {
                    Console.WriteLine($"Järjestys on: {numy}, {numx}, {numz}");
                }
                else
                {
                    if (numy < numz)
                    {
                        Console.WriteLine($"Järjestys on: {numy}, {numz}, {numx}");
                    }
                    else
                    {
                        Console.WriteLine($"Järjestys on: {numz}, {numy}, {numx}");
                    }

                }
            }
            Console.ReadKey();
        }
    }
}
