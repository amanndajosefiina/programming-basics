using System;
using System.Linq;

namespace reference_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tarkistaa viitenumeron.");

            string refNum = Console.ReadLine();
            string refNum1 = refNum.Replace(" ", "");
            int[] multip = { 1, 3, 7 };
            refNum1 = refNum1.Remove(refNum1.Length - 1);
            char[] refArray = refNum1.ToCharArray();
            int sum = 0;
            int y = 0;

            for(int i = 0; i < refArray.Length; i++)
            {
                if (y > 2)
                {
                    y = 0;
                }
                sum = sum + (multip[y]) * int.Parse(refArray[i].ToString());
                y++;
            }

            int chk = (int)(Math.Ceiling((decimal)sum / 10) * 10);
            int diff = chk - sum;

            if (diff == int.Parse(refNum[refNum.Length -1].ToString())) 
            {
                Console.WriteLine($"{refNum} Reference number is okay");
            }

            else
            {
                Console.WriteLine($"{refNum} Reference number is incorrect.");
            }

            Console.ReadKey();
        }
    }
}
