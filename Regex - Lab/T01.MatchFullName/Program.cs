using System;
using System.Text.RegularExpressions;

namespace T01.MatchFullName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"\b[A-Z]{1}[a-z]+\s[A-Z]{1}[a-z]+\b";
            MatchCollection matches = Regex.Matches(input, pattern);
            Console.WriteLine(String.Join(" ", matches));
        }
    }
}
