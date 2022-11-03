using System;
using System.Linq;

namespace T07.EqualArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstArray = Console.ReadLine().Split();
            var secondArray = Console.ReadLine().Split();
            var isIdentical = true;
            var sum = 0;
            for (int i = 0; i < firstArray.Length; i++)
            {
                if (firstArray[i] != secondArray[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    isIdentical = false;
                    break;
                }
            }
            if (isIdentical)
            {
                for (int j = 0; j < firstArray.Length; j++)
                {
                    sum += int.Parse(firstArray[j]);
                }
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
        }
    }
}
