using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T02.Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> participants = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
            SortedDictionary<string, int> participantsInTheRace = new SortedDictionary<string, int>();

            string newLine;
            while ((newLine = Console.ReadLine()) != "end of race")
            {
                StringBuilder currName = new StringBuilder();
                for (int i = 0; i < newLine.Length; i++)
                {
                    if (char.IsLetter(newLine[i]))
                    {
                        currName.Append(newLine[i]);
                        newLine.Remove(i);
                    }
                }
                string name = currName.ToString();

                int distanceForCurrParticipant = 0;
                if (participants.Contains(name))
                {
                    foreach (char currChar in newLine)
                    {
                        if (char.IsDigit(currChar))
                        {
                            distanceForCurrParticipant += currChar - 48;
                        }
                    }
                }
                else
                {
                    continue;
                }

                if (participantsInTheRace.ContainsKey(name))
                {
                    participantsInTheRace[name] += distanceForCurrParticipant;
                    continue;
                }

                participantsInTheRace.Add(name, distanceForCurrParticipant);
            }

            Dictionary<string, int> finalTopThree = participantsInTheRace.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

            if (finalTopThree.Count > 0)
            {
                Console.WriteLine($"1st place: {finalTopThree.First().Key.Trim()}");
                finalTopThree.Remove(finalTopThree.Keys.First());
            }
            if (finalTopThree.Count > 0)
            {
                Console.WriteLine($"2nd place: {finalTopThree.First().Key.Trim()}");
                finalTopThree.Remove(finalTopThree.Keys.First());
            }
            if (finalTopThree.Count > 0)
            {
                Console.WriteLine($"3rd place: {finalTopThree.First().Key.Trim()}");
                finalTopThree.Remove(finalTopThree.Keys.First());
            }
        }
    }
}
