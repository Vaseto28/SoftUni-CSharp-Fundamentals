using System;
using System.Collections.Generic;

namespace T01.CountCharsInString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Dictionary<char, int> chars = new Dictionary<char, int>();

            foreach (string word in words)
            {
                char[] currWord = word.ToCharArray();

                for (int i = 0; i < currWord.Length; i++)
                {
                    if (!chars.ContainsKey(currWord[i]))
                    {
                        chars.Add(currWord[i], 0);
                    }

                    chars[currWord[i]]++;
                }
            }

            foreach (var kvp in chars)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
