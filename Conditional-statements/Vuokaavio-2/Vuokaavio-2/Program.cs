using System;

namespace Vuokaavio_2
{
    class Program
    {
        static void Main(string[] args)
        
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
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

            else if (age >= 65)
            {
                discount = 50;
                discounted = true;
            }

            else if (age >= 7 && age <= 15)
            {
                discount = 50;
                discounted = true;
            }


            //varusmies 
            Console.Write("Oletko varusmies? Y/N: ");
            string vastaus = Console.ReadLine();
            bool varusmies;
            if (vastaus == "Y" || vastaus == "y")
            {
                varusmies = true;
            }
            else
            {
                varusmies = false;
            }

            if (varusmies == true && discounted == false)
            {
                discount = 50;
                discounted = true;

            }

            //opiskelija 
            Console.Write("Oletko opiskelija? Y/N: ");
            string vastaus1 = Console.ReadLine();
            Console.Write("Oletko MTK:n jäsen?Y/N: ");
            string vastaus2 = Console.ReadLine();

            bool mtk;
            bool opiskelija;

            if (vastaus1 == "Y" || vastaus1 == "y")
            {
                opiskelija = true;
            }
            else
            {
                opiskelija = false;
            }

            if (vastaus2 == "Y" || vastaus2 == "y")
            {
                mtk = true;
            }
            else
            {
                mtk = false;
            }

            if (opiskelija == true && mtk == true && discounted == false)
            {
                discount = 60;
                discounted = true;
            }

            else
            {
                if (opiskelija == true && discounted == false)
                {
                    discount = 45;
                    discounted = true;
                }

                else if(mtk == true && discounted == false)
                {
                    discount = 15;
                    discounted = true;
                }
            }

            decimal lopullinenHinta = price - (price * (discount / 100m));
            Console.WriteLine($"Lopullinen hintasi oli: {lopullinenHinta}");
            Console.WriteLine("Tervetuloa!");
            Console.ReadKey();

        }
    }
}





            
            



            
         
                      


