using System;
using System.Collections.Generic;

namespace T08.LettersChangeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] combinations = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            List<decimal> finalNumbers = new List<decimal>();

            foreach (string combination in combinations)
            {
                char firstLetter = combination[0];
                char secondLetter = combination[combination.Length - 1];
                decimal num = decimal.Parse(combination.Substring(1, combination.Length - 2));

                //For the first letter
                if (firstLetter >= 65 && firstLetter <= 90)
                {
                    //Letter is upper case
                    num = num / (firstLetter - 64);
                }
                else
                {
                    //Letter is lower case
                    num = num * (firstLetter - 96);
                }

                //For the second letter
                if (secondLetter >= 65 && secondLetter <= 90)
                {
                    //Letter is upperCase
                    num = num - (secondLetter - 64);
                }
                else
                {
                    //Letter is lowercase
                    num = num + (secondLetter - 96);
                }

                finalNumbers.Add(num);
            }

            decimal sum = 0.0m;
            foreach (decimal num in finalNumbers)
            {
                sum += num;
            }

            Console.WriteLine($"{sum:f2}");
        }
    }
}
