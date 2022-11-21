using System;
using System.Text.RegularExpressions;

namespace T03.SoftuniBarIncome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\%(?<costumer>[A-Z]{1}[a-z]+)\%[^\|\$\%\.]*?\<(?<product>\w+)\>[^\|\$\%\.]*?\|(?<quantity>\d+)\|[^\|\$\%\.]*?(?<price>\d+(\,\d+)?)\$";

            decimal totalPrice = 0m;
            string rawInput;
            while ((rawInput = Console.ReadLine()) != "end of shift")
            {
                Match currMatch = Regex.Match(rawInput, pattern);

                if (currMatch.Success)
                {
                    string costumer = currMatch.Groups["costumer"].Value;
                    string product = currMatch.Groups["product"].Value;
                    int qty = int.Parse(currMatch.Groups["quantity"].Value);
                    decimal price = decimal.Parse(currMatch.Groups["price"].Value);

                    decimal totalPriceForCurrCostumer = qty * price;
                    totalPrice+=totalPriceForCurrCostumer;

                    Console.WriteLine($"{costumer}: {product} - {totalPriceForCurrCostumer:f2}");
                }
            }

            Console.WriteLine($"Total income: {totalPrice:f2}");
        }
    }
}
