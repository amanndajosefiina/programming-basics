using System;

namespace table5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma määrittelee kolme kokonaislukutaulukkoa.");
            Console.WriteLine("\t01 02 03 04 05 06 07 08 09 10");

            Random rnd = new Random();

            int[] arrT_1 = new int[10];
            int[] arrT_2 = new int[10];
            int[] arrT_3 = new int[10];

            for (int i = 0; i < 10; i++)
            {
                arrT_1[i] = rnd.Next(0, 10);
                arrT_2[i] = rnd.Next(0, 10);

                if (arrT_1[i] < arrT_2[i])
                {
                    arrT_3[i] = arrT_2[i];
                }
                else
                {
                    arrT_3[i] = arrT_1[i];
                }
            }

            Console.Write("arrT_1:");
            
            for (int i = 0; i < 10; i++)
            {
                Console.Write($" {arrT_1[i]:00}");
            }
            Console.Write("\narrT_2:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($" {arrT_2[i]:00}");
            }
            Console.Write("\narrT_3:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($" {arrT_3[i]:00}");
            }

            Console.ReadKey();
        }
    }
}
