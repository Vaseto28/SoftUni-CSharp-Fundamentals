using System;
using System.Text.RegularExpressions;

namespace T03.MatchDates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"(?<day>\d{2})(?<separators>[\.\-\/])(?<month>[A-Z]{1}[a-z]{2})\2(?<year>\d{4})";
            MatchCollection matches = Regex.Matches(input, pattern);
            foreach (Match match in matches)
            {
                string day = match.Groups["day"].Value;
                string month = match.Groups["month"].Value;
                string year = match.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
