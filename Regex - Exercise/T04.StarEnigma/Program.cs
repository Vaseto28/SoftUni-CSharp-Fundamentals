using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace T04.StarEnigma
{
    internal class Program
    {
        public static object StirngBuilder { get; private set; }

        static void Main(string[] args)
        {
            string patternForDecript = @"[s,t,a,r]";
            string patternForPlanet = @"\@(?<planet>[A-Za-z]+)[^\@\-\!\:\>]*?\:(?<popuation>\d+)[^\@\-\!\:\>]*?\!(?<attackType>[A|D])\![^\@\-\!\:\>]*?[\-\>]+(?<soldiers>\d+)[^\@\-\!\:\>]*?";

            List<string> attackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();

            int messagesCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < messagesCount; i++)
            {
                string currMessage = Console.ReadLine();
                MatchCollection matches = Regex.Matches(currMessage, patternForDecript, RegexOptions.IgnoreCase);

                StringBuilder currPlanet = new StringBuilder();
                foreach (char currChar in currMessage)
                {
                    int newCharacter = currChar - matches.Count;
                    char finalCharacter = (char)newCharacter;
                    currPlanet.Append(finalCharacter);
                }

                Match newPlanet = Regex.Match(currPlanet.ToString(), patternForPlanet);

                if (newPlanet.Success)
                {
                    string planetName = newPlanet.Groups["planet"].Value;
                    char attackType = char.Parse(newPlanet.Groups["attackType"].Value);

                    if (attackType == 'A')
                    {
                        attackedPlanets.Add(planetName);
                    }
                    else
                    {
                        destroyedPlanets.Add(planetName);
                    }
                }
            }

            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");
            if (attackedPlanets.Count != 0)
            {
                attackedPlanets = attackedPlanets.OrderBy(x => x).ToList();
                foreach (string planet in attackedPlanets)
                {
                    Console.WriteLine($"-> {planet}");
                }
            }

            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
            if (destroyedPlanets.Count != 0)
            {
                destroyedPlanets = destroyedPlanets.OrderBy(x => x).ToList();
                foreach (string planet in destroyedPlanets)
                {
                    Console.WriteLine($"-> {planet}");
                }
            }
        }
    }
}
