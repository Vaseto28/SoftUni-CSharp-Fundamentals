using System;
using System.Linq;

namespace T03.RoundingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] nums = Console.ReadLine().Split().Select(double.Parse).ToArray();
            for (int i = 0; i < nums.Length; i++)
            {
                var currItem = Math.Round(nums[i], MidpointRounding.AwayFromZero);
                Console.WriteLine($"{nums[i]} => {currItem}");
            }
        }
    }
}
