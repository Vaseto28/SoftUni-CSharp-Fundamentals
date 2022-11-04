using System;
using System.Linq;

namespace T06.EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            for (int i = 0; i < array.Length; i++)
            {
                var leftSum = 0;
                for (int leftSumLoop = i; leftSumLoop < i + 1; leftSumLoop++)
                {
                    var currNum = array[leftSumLoop];
                    leftSum += currNum;
                }
                var rightSum = 0;
                for (int rightSumLoop = i + 1; rightSumLoop < array.Length; rightSumLoop++)
                {
                    var currNum = array[rightSumLoop];
                    rightSum += currNum;
                }
                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
