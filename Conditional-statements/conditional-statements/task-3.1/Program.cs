using System;

namespace task_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // define instructions
            Console.WriteLine("Ohjelma tulostaa positiivinen, negatiivinen tai nolla");
            bool isNumber;
            do
            {
                Console.Write("Syötä luku: ");
                // define variables
                string userInput;
                userInput = Console.ReadLine();

                int evaluatedNumber;
                isNumber = int.TryParse(userInput, out evaluatedNumber);
                // program logic
                if (isNumber == true)
                {
                    int.TryParse(userInput, out evaluatedNumber);

                    if (evaluatedNumber < 0 && evaluatedNumber % 2 != 0)
                    {
                        Console.WriteLine($"Numero {evaluatedNumber} on negatiivinen ja pariton");
                    }
                    if (evaluatedNumber > 0 && evaluatedNumber % 2 != 0)
                    {
                        Console.WriteLine($"Numero {evaluatedNumber} on positiivinen ja pariton");
                    }
                    if (evaluatedNumber < 0 && evaluatedNumber % 2 == 0)
                    {
                        Console.WriteLine($"Numero {evaluatedNumber} on negatiivinen ja parillinen");
                    }
                    if (evaluatedNumber > 0 && evaluatedNumber % 2 == 0)
                    {
                        Console.WriteLine($"Numero {evaluatedNumber} on positiivinen ja parillinen");
                    }
                    if (evaluatedNumber == 0)
                    {
                        Console.WriteLine($"Numero on nolla");
                    }

                }

                else
                {
                    Console.WriteLine("Syötit muuta kuin numeroita!");

                }
            } while (isNumber == false);
            Console.ReadKey();
        }
    }
}
