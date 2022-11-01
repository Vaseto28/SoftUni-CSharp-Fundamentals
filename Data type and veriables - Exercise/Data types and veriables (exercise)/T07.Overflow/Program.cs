using System;

namespace T07.Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = int.Parse(Console.ReadLine());
            var sum = 0;
            var isOverflowed = false;
            for (int i = 1; i <= lines; i++)
            {
                var litres = int.Parse(Console.ReadLine());
                sum += litres;
                if (i>lines)
                {
                    if (isOverflowed)
                    {
                        break;
                    }
                }
                if (sum > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                    sum -= litres;
                    isOverflowed = true;
                    continue;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
