using System;

namespace table2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma arpoo 7 eri lukua 1-40 ja tulostaa arvotut luvut pienimmästä suurimpaan.");

            int[] lotto = new int[40];
            Random rnd = new Random();
            int rndIndex = 0;
            
            //lottorivin arvonta
            for (int i = 0; i < 7; i++)
            {
                rndIndex = rnd.Next(1, 40);
                if (lotto[rndIndex] == 0)
                    lotto[rndIndex] = 1;
                else
                    i--;
            }

            //lisänumeroiden arvonta
            for (int i = 0; i < 2; i++)
            {
                rndIndex = rnd.Next(0, 40);
                if (lotto[rndIndex] == 0)
                    lotto[rndIndex] = 2;
                else
                    i--;
            }

            //luodaan oikea lottorivi tulostusta varten
            string rightLotteryRow = "";
            string extraNumbers = "";
            for (int i = 0; i < 40; i++)
            {
                if (lotto[i] == 1)
                    rightLotteryRow += $"{i+1} ";
                if (lotto[i] == 2)
                    extraNumbers += $"{i+1} ";
            }

            Console.WriteLine($"Loton oikea rivi: {rightLotteryRow}");
            Console.WriteLine($"Lisänumerot: {extraNumbers}");
            Console.WriteLine($"Tuplausnumero: {rnd.Next(1, 41)}");

            Console.ReadKey();
        }
    }
}
