using System;
using System.Collections.Generic;

namespace T02.OddOccurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> occurrencies = new Dictionary<string, int>();

            foreach (var word in words)
            {
                string currWord = word.ToLower();

                if (!occurrencies.ContainsKey(currWord))
                {
                    occurrencies.Add(currWord, 0);
                }

                occurrencies[currWord]++;
            }

            foreach (var kvp in occurrencies)
            {
                if (kvp.Value % 2 != 0)
                {
                    Console.Write($"{kvp.Key} ");
                }
            }
        }
    }
}
