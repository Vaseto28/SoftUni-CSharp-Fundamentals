using System;
using System.Linq;
using System.Collections.Generic;

namespace T04.MoovingTarget
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] arguments = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                var action = arguments[0];
                switch (action)
                {
                    case "Shoot":
                        var indexToShoot = int.Parse(arguments[1]);
                        var powerOfShooting = int.Parse(arguments[2]);

                        if (indexToShoot >= 0 && indexToShoot < targets.Count)
                        {
                            targets[indexToShoot] -= powerOfShooting;
                            if (targets[indexToShoot] <= 0)
                            {
                                targets.RemoveAt(indexToShoot);
                            }
                        }
                        else
                        {
                            continue;
                        }
                        break;
                    case "Add":
                        var indexToAdd = int.Parse(arguments[1]);
                        var valueToAdd = int.Parse(arguments[2]);

                        if (indexToAdd >= 0 && indexToAdd < targets.Count)
                        {
                            targets.Insert(indexToAdd, valueToAdd);
                        }
                        else
                        {
                            Console.WriteLine("Invalid placement!");
                            continue;
                        }
                        break;
                    case "Strike":
                        var indexToStrike = int.Parse(arguments[1]);
                        var strikeRadius = int.Parse(arguments[2]);
                        var isIndexValid = indexToStrike - strikeRadius >= 0 && indexToStrike - strikeRadius < targets.Count && indexToStrike + strikeRadius >= 0 && indexToStrike + strikeRadius < targets.Count;
                        if (isIndexValid)
                        {
                            targets.RemoveRange(indexToStrike - strikeRadius, strikeRadius * 2 + 1);
                        }
                        else
                        {
                            Console.WriteLine("Strike missed!");
                            continue;
                        }
                        break;
                }

            }
            Console.WriteLine(String.Join("|", targets));
        }
    }
}
