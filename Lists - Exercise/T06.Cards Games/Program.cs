using System;
using System.Linq;
using System.Collections.Generic;

namespace T06.Cards_Games
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstDeck = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondDeck = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                var currCardFromFirstDeck = firstDeck[0];
                var currCardFromSecondDeck = secondDeck[0];
                if (currCardFromFirstDeck > currCardFromSecondDeck)
                {
                    firstDeck.RemoveAt(0);
                    secondDeck.RemoveAt(0);
                    firstDeck.Add(currCardFromSecondDeck);
                    firstDeck.Add(currCardFromFirstDeck);
                }
                else if (currCardFromFirstDeck < currCardFromSecondDeck)
                {
                    firstDeck.RemoveAt(0);
                    secondDeck.RemoveAt(0);
                    secondDeck.Add(currCardFromFirstDeck);
                    secondDeck.Add(currCardFromSecondDeck);
                }
                else
                {
                    firstDeck.RemoveAt(0);
                    secondDeck.RemoveAt(0);
                }

                if (firstDeck.Count == 0 || secondDeck.Count == 0)
                {
                    if (firstDeck.Count == 0)
                    {
                        Console.WriteLine($"Second player wins! Sum: {secondDeck.Sum()}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"First player wins! Sum: {firstDeck.Sum()}");
                        break;
                    }
                }
            }
        }
    }
}
