using System;
using System.Collections.Generic;
using System.Linq;

namespace T01.SumAdjacentEqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<decimal> numbers = Console.ReadLine().Split().Select(decimal.Parse).ToList();
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    numbers[i] = numbers[i] + numbers[i + 1];
                    numbers.RemoveAt(i + 1);
                    i = -1;
                }
            }
            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
