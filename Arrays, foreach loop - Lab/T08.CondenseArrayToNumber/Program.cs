using System;
using System.Linq;

namespace T08.CondenseArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var firstLength = nums.Length;
            for (int i = 0; i < firstLength - 1; i++)
            {
                int[] condensed = new int[nums.Length];
                for (int j = 0; j < nums.Length - 1; j++)
                {
                    condensed[j] = nums[j] + nums[j + 1];
                }
                nums = condensed;
            }
            Console.WriteLine(nums[0]);
        }
    }
}
