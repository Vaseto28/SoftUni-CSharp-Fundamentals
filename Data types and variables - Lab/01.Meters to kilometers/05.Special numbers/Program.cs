using System;

namespace _05.Special_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                var sum = 0;
                var currentNumber = i;
                while (currentNumber > 0)
                {
                    var currentLastNum = currentNumber % 10;
                    sum += currentLastNum;
                    currentNumber /= 10;
                }
                bool isSpecial = sum == 5 || sum == 7 || sum == 11;
                Console.WriteLine($"{i} -> {isSpecial}");
            }
        }
    }
}
