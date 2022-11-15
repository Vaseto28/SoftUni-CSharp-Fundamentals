using System;
using System.Collections.Generic;

namespace T08.CompanyUsers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>();

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] info = command.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                string companyName = info[0];
                string companyEployeeId = info[1];

                if (companies.ContainsKey(companyName))
                {
                    if (!companies[companyName].Contains(companyEployeeId))
                    {
                        companies[companyName].Add(companyEployeeId);
                        continue;
                    }

                    continue;
                }

                companies.Add(companyName, new List<string> { companyEployeeId });
            }

            foreach (var company in companies)
            {
                Console.WriteLine(company.Key);
                foreach (var companyEmployeeId in company.Value)
                {
                    Console.WriteLine($"-- {companyEmployeeId}");
                }
            }
        }
    }
}
