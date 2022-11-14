using System;
using System.Collections.Generic;

namespace T03.WordSynonyms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wordSynonymPairs = int.Parse(Console.ReadLine());

            Dictionary<string, List<string>> wordsSynonyms = new Dictionary<string, List<string>>();

            for (int i = 1; i <= wordSynonymPairs; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (!wordsSynonyms.ContainsKey(word))
                {
                    wordsSynonyms.Add(word, new List<string>());
                }
                
                wordsSynonyms[word].Add(synonym);
            }

            foreach (var word in wordsSynonyms)
            {
                Console.WriteLine($"{word.Key} - {string.Join(", ", word.Value)}");
            }
        }
    }
}
