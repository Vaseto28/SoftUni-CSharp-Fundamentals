using System;

namespace T03.CounterStrike
{
    class Program
    {
        static void Main(string[] args)
        {
            var initialEnergy = int.Parse(Console.ReadLine());
            string command;

            var wonBattles = 0;
            var loseBattle = false;
            while ((command = Console.ReadLine()) != "End of battle")
            {
                var distance = int.Parse(command);
                if (initialEnergy >= distance)
                {
                    wonBattles++;
                    initialEnergy -= distance;
                    if (wonBattles % 3 == 0)
                    {
                        initialEnergy += wonBattles;
                    }
                }
                else
                {
                    loseBattle = true;
                    break;
                }
            }

            if (loseBattle)
            {
                Console.WriteLine($"Not enough energy! Game ends with {wonBattles} won battles and {Math.Abs(initialEnergy)} energy");
            }
            else
            {
                Console.WriteLine($"Won battles: {wonBattles}. Energy left: {initialEnergy}");
            }
        }
    }
}
