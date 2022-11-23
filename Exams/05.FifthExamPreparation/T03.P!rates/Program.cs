using System;
using System.Collections.Generic;

namespace T03.P_rates
{
    class City
    {
        public City(string city, int population, int gold)
        {
            this.CityName = city;
            this.Population = population;
            this.Gold = gold;
        }
        public string CityName { get; set; }

        public int Population { get; set; }

        public int Gold { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, City> cities = new Dictionary<string, City>();
            string command;
            while ((command = Console.ReadLine()) != "Sail")
            {
                string[] info = command.Split("||");

                string city = info[0];
                int population = int.Parse(info[1]);
                int gold = int.Parse(info[2]);

                if (!cities.ContainsKey(city))
                {
                    cities.Add(city, new City(city, population, gold));
                    continue;
                }

                cities[city].Population += population;
                cities[city].Gold += gold;
            }

            string secondCommand;
            while ((secondCommand = Console.ReadLine()) != "End")
            {
                string[] currEvent = secondCommand.Split("=>");

                string action = currEvent[0];
                if (action == "Plunder")
                {
                    string cityName = currEvent[1];
                    int population = int.Parse(currEvent[2]);
                    int gold = int.Parse(currEvent[3]);

                    if (cities.ContainsKey(cityName))
                    {
                        cities[cityName].Population -= population;
                        cities[cityName].Gold -= gold;
                        Console.WriteLine($"{cityName} plundered! {gold} gold stolen, {population} citizens killed.");

                        if (cities[cityName].Population <= 0)
                        {
                            cities.Remove(cityName);
                            Console.WriteLine($"{cityName} has been wiped off the map!");
                            continue;
                        }

                        if (cities[cityName].Gold <= 0)
                        {
                            cities.Remove(cityName);
                            Console.WriteLine($"{cityName} has been wiped off the map!");
                            continue;
                        }
                    }
                }
                else if (action == "Prosper")
                {
                    string cityName = currEvent[1];
                    int gold = int.Parse(currEvent[2]);

                    if (gold < 0)
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                        continue;
                    }

                    cities[cityName].Gold += gold;
                    Console.WriteLine($"{gold} gold added to the city treasury. {cityName} now has {cities[cityName].Gold} gold.");
                }
            }

            if (cities.Count > 0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {cities.Count} wealthy settlements to go to:");
                foreach (var city in cities)
                {
                    City cityName = city.Value;
                    Console.WriteLine($"{cityName.CityName} -> Population: {cityName.Population} citizens, Gold: {cityName.Gold} kg");
                }
            }
            else
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
        }
    }
}
