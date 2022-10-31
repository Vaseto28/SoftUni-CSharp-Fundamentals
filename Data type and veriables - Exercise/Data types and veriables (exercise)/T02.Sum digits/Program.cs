using System;

namespace T02.Sum_digits
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var sum = 0;
            while (num != 0)
            {
                var currentDigit = num % 10;
                num /= 10;
                sum += currentDigit;
            }
            Console.WriteLine(sum);
        }
    }
}
