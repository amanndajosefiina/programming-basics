using System;

namespace task_2
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; // paskaa
            // define instructions
            Console.WriteLine("Ohjelma tarkistaa onko syötetty luku parillinen vai pariton");
            bool isNumber;
            string userInput = Console.ReadLine();
            int evaluatedNumber;
            isNumber = int.TryParse(userInput, out evaluatedNumber);

            // program logic
            if (evaluatedNumber % 2 == 0)
            {
                Console.WriteLine($"Syötit luvun {evaluatedNumber}, se on parillinen");
            }
            else
            {
                Console.WriteLine($"Syötit luvun {evaluatedNumber}, se on pariton");
            }
            Console.ReadKey();
        }
    }
}
