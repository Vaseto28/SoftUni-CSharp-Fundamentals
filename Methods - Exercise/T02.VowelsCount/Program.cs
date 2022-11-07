using System;

namespace T02.VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            FindingTheVowelLetters(text);
        }

        static void FindingTheVowelLetters(string text)
        {
            var vowelCounter = 0;
            for (int i = 0; i < text.Length; i++)
            {
                var currLetter = text[i];
                if (currLetter == 'a' || currLetter == 'e' || currLetter == 'i' || currLetter == 'o' || currLetter == 'u' || currLetter == 'A' || currLetter == 'E' || currLetter == 'I' || currLetter == 'O' || currLetter == 'U')
                {
                    vowelCounter++;
                }
            }
            Console.WriteLine(vowelCounter);
        }
    }
}
