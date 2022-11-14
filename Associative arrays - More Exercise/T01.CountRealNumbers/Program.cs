using System;
using System.Collections.Generic;
using System.Linq;

namespace T01.CountRealNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<int, int> frequences = new SortedDictionary<int, int>();

            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(num => int.Parse(num))
                .ToArray();

            foreach (int number in numbers)
            {
                if (frequences.ContainsKey(number))
                {
                    frequences[number]++;
                }
                else
                {
                    frequences.Add(number, 1);
                }
            }

            foreach (var kvp in frequences)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
