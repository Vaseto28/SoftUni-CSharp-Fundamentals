using System;

namespace foreign_languages
{
    class Program
    {
        static void Main(string[] args)
        {
            var country = Console.ReadLine();
            switch (country)
            {
                case "England":
                case "USA":
                    Console.WriteLine("English");
                    break;
                case "Spain":
                case "Argentina":
                case "Mexico":
                    Console.WriteLine("Spanish");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}
