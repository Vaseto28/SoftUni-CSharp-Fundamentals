using System;
using System.Collections.Generic;

namespace T01.RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Random randomizedIndex = new Random();
            for (int i = 0; i < words.Length; i++)
            {
                var currRandomIndex = randomizedIndex.Next(0, words.Length);
                var currElement = words[i];
                words[i] = words[currRandomIndex];
                words[currRandomIndex] = currElement; 
            }

            Console.WriteLine(String.Join(Environment.NewLine, words));
        }
    }
}
