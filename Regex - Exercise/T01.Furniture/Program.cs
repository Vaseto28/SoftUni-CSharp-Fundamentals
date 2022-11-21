using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace T01.Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"[\>]{2}(?<product>[A-Za-z]+)[\<]{2}(?<price>\d+(\,\d+)?)\!(?<quantity>\d+)\b";

            decimal sum = 0m;
            List<string> furnitures = new List<string>();

            string inputLine;
            while ((inputLine = Console.ReadLine()) != "Purchase")
            {
                if (Regex.IsMatch(inputLine, pattern))
                {
                    Match currMatch = Regex.Match(inputLine, pattern);

                    string currFurniture = currMatch.Groups["product"].Value;
                    decimal currFurniturePrice = decimal.Parse(currMatch.Groups["price"].Value);
                    int currFurnitureQuantity = int.Parse(currMatch.Groups["quantity"].Value);

                    furnitures.Add(currFurniture);
                    sum += currFurniturePrice * currFurnitureQuantity;
                }
            }

            Printing(furnitures, sum);
        }

        static void Printing(List<string> furnitures, decimal sum)
        {
            Console.WriteLine("Bought furniture:");

            foreach (string furniture in furnitures)
            {
                Console.WriteLine(furniture);
            }

            Console.WriteLine($"Total money spend: {sum:f2}");
        }
    }
}
