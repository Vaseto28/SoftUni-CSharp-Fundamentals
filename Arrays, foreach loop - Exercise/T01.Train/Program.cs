using System;

namespace T01.Train
{
    class Program
    {
        static void Main(string[] args)
        {
            var wagoons = int.Parse(Console.ReadLine());
            int[] peopleInWagoons = new int[wagoons];
            var sum = 0;
            for (int i = 0; i < wagoons; i++)
            {
                var peopleInCurrWagoon = int.Parse(Console.ReadLine());
                peopleInWagoons[i] = peopleInCurrWagoon;
                sum += peopleInCurrWagoon;
            }
            Console.WriteLine(String.Join(" ", peopleInWagoons));
            Console.WriteLine(sum);
        }
    }
}
