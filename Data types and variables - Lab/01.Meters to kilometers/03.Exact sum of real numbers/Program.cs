using System;

namespace _03.Exact_sum_of_real_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = int.Parse(Console.ReadLine());
            var sum = (decimal)0.0;
            for (int i = 0; i < numbers; i++)
            {
                var num = decimal.Parse(Console.ReadLine());
                sum += num;
            }
            Console.WriteLine(sum);
        }
    }
}
