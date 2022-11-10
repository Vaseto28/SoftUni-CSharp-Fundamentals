using System;
using System.Linq;
using System.Collections.Generic;

namespace T05Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string[] bombInfo = Console.ReadLine().Split().ToArray();
            var bombNum = int.Parse(bombInfo[0]);
            var bombPower = int.Parse(bombInfo[1]);
            while (true)
            {
                var indexOfBomb = numbers.IndexOf(bombNum);
                if (indexOfBomb != -1)
                {
                    DetonatingSingleBomb(numbers, bombNum, indexOfBomb, bombPower);
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(numbers.Sum());
        }

        static void DetonatingSingleBomb(List<int> numbers, int bombNum, int indexOfBomb, int bombPower)
        {
            var startPoint = indexOfBomb - bombPower;
            var finalPoint = indexOfBomb + bombPower;
            if (startPoint < 0)
            {
                startPoint = 0;
            }
            if (finalPoint >= numbers.Count)
            {
                finalPoint = numbers.Count - 1;
            }
            for (int i = startPoint; i <= finalPoint; i++)
            {
                var counter = startPoint;
                numbers.RemoveAt(counter);
            }
        }
    }
}
