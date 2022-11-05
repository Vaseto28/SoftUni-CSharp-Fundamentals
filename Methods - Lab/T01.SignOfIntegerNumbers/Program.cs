using System;

namespace T01.SignOfIntegerNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            SignOfNumber(num);
        }

        static void SignOfNumber(int num)
        {
            if (num>0)
            {
                Console.WriteLine($"The number {num} is positive.");
            }
            else if (num<0)
            {
                Console.WriteLine($"The number {num} is negative.");
            }
            else
            {
                Console.WriteLine($"The number {num} is zero.");
            }
        }
    }
}
