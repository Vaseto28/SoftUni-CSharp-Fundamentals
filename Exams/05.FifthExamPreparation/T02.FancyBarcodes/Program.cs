using System;
using System.Text;
using System.Text.RegularExpressions;

namespace T02.FancyBarcodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\@\#+(?<productGroup>[A-Z]{1}[A-Za-z0-9]{4,}[A-Z]{1})\@\#+";

            int barcodesCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < barcodesCount; i++)
            {
                string currBarcode = Console.ReadLine();

                Match currMatch = Regex.Match(currBarcode, pattern);

                if (currMatch.Success)
                {
                    StringBuilder currProductGroup = new StringBuilder();
                    foreach (char currChar in currBarcode)
                    {
                        if (char.IsDigit(currChar))
                        {
                            currProductGroup.Append(currChar);
                        }
                    }

                    if (currProductGroup.ToString().Length == 0)
                    {
                        currProductGroup.Append("00");
                    }

                    Console.WriteLine($"Product group: {currProductGroup}");
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }
        }
    }
}
