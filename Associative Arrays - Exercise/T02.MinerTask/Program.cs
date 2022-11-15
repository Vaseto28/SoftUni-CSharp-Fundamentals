using System;
using System.Collections.Generic;

namespace T02.AMinerTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string resource;
            Dictionary<string, int> resources = new Dictionary<string, int>();

            while ((resource = Console.ReadLine()) != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());

                if (!resources.ContainsKey(resource))
                {
                    resources.Add(resource, 0);
                }

                resources[resource] += quantity;
            }

            foreach (var kvp in resources)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
