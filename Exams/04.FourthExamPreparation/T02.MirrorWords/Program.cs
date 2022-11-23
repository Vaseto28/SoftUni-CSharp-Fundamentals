using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace T04.MirrorWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"(\@|\#)(?<firstWord>[A-Za-z]{3,})\1\1(?<secondWord>[A-Za-z]{3,})\1";
            int mirrorWordsCounter = 0;
            Dictionary<string, string> words = new Dictionary<string, string>();

            MatchCollection matches = Regex.Matches(text, pattern);

            foreach (Match match in matches)
            {
                string firstWord = match.Groups["firstWord"].Value;
                string secondWord = match.Groups["secondWord"].Value;

                StringBuilder reversedSecondWord = new StringBuilder();
                for (int i = secondWord.Length - 1; i >= 0; i--)
                {
                    reversedSecondWord.Append(secondWord[i]);
                }

                if (reversedSecondWord.ToString() == firstWord)
                {
                    words.Add(firstWord, secondWord);
                    mirrorWordsCounter++;
                }
            }

            if (matches.Count == 0)
            {
                Console.WriteLine("No word pairs found!");
            }
            else
            {
                Console.WriteLine($"{matches.Count} word pairs found!");
            }

            if (mirrorWordsCounter == 0)
            {
                Console.WriteLine("No mirror words!");
            }
            else
            {
                Console.WriteLine("The mirror words are:");
                Console.WriteLine(String.Join(", ", words.Select(x => $"{x.Key} <=> {x.Value}")));
            }
        }
    }
}
