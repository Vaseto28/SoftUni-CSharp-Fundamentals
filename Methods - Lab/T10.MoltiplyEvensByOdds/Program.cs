using System;

namespace T10.MoltiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = Math.Abs(int.Parse(Console.ReadLine()));
            var evenSum = GetTheEvenSum(num);
            var oddSum = GetTheOddSum(num);
            var multiplication = evenSum * oddSum;
            Console.WriteLine(multiplication);
        }

        static int GetTheEvenSum(int num)
        {
            var evenSum = 0;
            while (num!=0)
            {
                var currNum = num % 10;
                if (currNum%2==0)
                {
                    evenSum += currNum;
                }
                num /= 10;
            }
            return evenSum;
        }

        static int GetTheOddSum(int num)
        {
            var oddSum = 0;
            while (num != 0)
            {
                var currNum = num % 10;
                if (currNum % 2 != 0)
                {
                    oddSum += currNum;
                }
                num /= 10;
            }
            return oddSum;
        }
    }
}
