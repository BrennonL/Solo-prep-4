using System;

using System.Collections.Generic;
namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> Numbers = new List<int>();

            Console.WriteLine("Enter a list of numbers, type 0 when finished");
            int Number = 0;

            int BigNumber = 0;
            do
            {
                Console.Write("Enter number: ");
                string NumberString = Console.ReadLine();
                Number = int.Parse(NumberString);

                if (Number != 0)
                {
                    Numbers.Add(Number);
                }

                if (Number > BigNumber)
                {
                    BigNumber = Number;
                }

            }while(Number != 0);

            float Total = 0;

            float NumberOfNumbers = 0;

            float Avarage = 0;

            foreach (int i in Numbers)
            {
                Console.WriteLine($"{i}");

                Total = i + Total;

                NumberOfNumbers ++;


            }

            Avarage = (float) (Total / NumberOfNumbers);

            Console.WriteLine($"The Bigest number is {BigNumber}");

            Console.WriteLine($"The sum is: {Total}");

            Console.WriteLine($"The average is: {Avarage}");


        }
    }
}
