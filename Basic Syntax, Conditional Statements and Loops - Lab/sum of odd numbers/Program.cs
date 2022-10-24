using System;

namespace sum_of_odd_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var range = int.Parse(Console.ReadLine());
            var sum = 0;
            for (int i = 0; i < range; i++)
            {
                int oddNumber = 1 + (2 * i);
                sum += oddNumber;
                Console.WriteLine(oddNumber);
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
