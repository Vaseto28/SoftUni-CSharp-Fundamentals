using System;

namespace T06.EvenAndOddSubtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split();
            var evenSum = 0;
            var oddSum = 0;
            var diff = 0;
            foreach (var item in nums)
            {
                if (int.Parse(item) % 2 == 0)
                {
                    evenSum += int.Parse(item);
                }
                else
                {
                    oddSum += int.Parse(item);
                }
            }
            diff = evenSum - oddSum;
            Console.WriteLine(diff);
        }
    }
}
