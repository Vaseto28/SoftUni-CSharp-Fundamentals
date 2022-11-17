using System;

namespace T01.ReverseStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word;

            while ((word = Console.ReadLine()) != "end")
            {
                char[] currWord = word.ToCharArray();
                Array.Reverse(currWord);
                string reversedWord = new string(currWord);

                Console.WriteLine($"{word} = {reversedWord}");
            }
        }
    }
}
