using System;

namespace T09.SpiceFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            var startingYeld = int.Parse(Console.ReadLine());
            long extractedSpice = 0;
            var days = 0;
            for (int i = startingYeld; i >= 100; i -= 10)
            {
                if (i<=0)
                {
                    extractedSpice += i;
                }
                else
                {
                    extractedSpice = extractedSpice + (i - 26);
                }
                days++;
            }
            Console.WriteLine(days);
            if (extractedSpice < 0)
            {
                Console.WriteLine(extractedSpice);
            }
            else
            {
                Console.WriteLine(extractedSpice - 26);
            }
        }
    }
}
