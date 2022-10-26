using System;

namespace _06.Strong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = Console.ReadLine();
            var sumFact = 0;
            for (int i = 0; i < num.Length; i++)
            {
                var currentCharacter = num[i];
                var currentDigit = (int)currentCharacter - 48;
                var factorialOfTheNumber = 1;
                for (int j = currentDigit; j > 1; j--)
                {
                    factorialOfTheNumber *= j;
                }
                sumFact += factorialOfTheNumber;
            }
            var num1 = int.Parse(num);
            if (sumFact == num1)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
