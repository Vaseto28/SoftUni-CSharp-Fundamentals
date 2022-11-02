using System;

namespace T05.SumOfEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nums = Console.ReadLine().Split();
            var sum = 0;
            foreach (var item in nums)
            {
                if (int.Parse(item) % 2 == 0)
                {
                    sum += int.Parse(item);
                }
            }
            Console.WriteLine(sum);
        }
    }
}
