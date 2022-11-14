using System;
using System.Linq;

namespace T04.WordFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            string[] filteredWords = words.Where(word => word.Length % 2 == 0).ToArray();

            foreach (string word in filteredWords)
            {
                Console.WriteLine(word);
            }
        }
    }
}
