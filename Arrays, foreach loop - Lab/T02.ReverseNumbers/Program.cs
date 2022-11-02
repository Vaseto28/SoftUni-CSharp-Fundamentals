using System;

namespace T02.ReverseNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = int.Parse(Console.ReadLine());
            int[] numbers = new int[nums];
            for (int i = 0; i < nums; i++)
            {
                var currNum = int.Parse(Console.ReadLine());
                numbers[i] = currNum;
            }
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                Console.Write($"{numbers[i]} ");
            }
        }
    }
}
