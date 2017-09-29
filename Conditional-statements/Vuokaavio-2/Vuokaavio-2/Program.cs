using System;

namespace Vuokaavio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int discount = 0;
            int price = 16;
            bool discounted = false;

            //ikäalennus
            Console.Write("Ikä: ");
            int age = int.Parse(Console.ReadLine());

            if (age < 7)
            {
                discount = 100;
                discounted = true;
            }
            else if (age >= 7 && age <= 15 && discounted == false)
            {
                discount = discount + 50;
                discounted = true;
            }


