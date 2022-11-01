using System;
using System.Numerics;

namespace T11.Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            var snowballs = int.Parse(Console.ReadLine());
            var biggestSnowballValue = BigInteger.Zero;
            var bestSnowballSnow = 0;
            var bestSnowballTime = 0;
            var bestSnowballQuality = 0;
            for (int i = 0; i < snowballs; i++)
            {
                var snowballSnow = int.Parse(Console.ReadLine());
                var snowballTime = int.Parse(Console.ReadLine());
                var snowballQuality = int.Parse(Console.ReadLine());
                var currSnowballValue = BigInteger.Pow(snowballSnow / snowballTime, snowballQuality);
                if (currSnowballValue > biggestSnowballValue)
                {
                    biggestSnowballValue = currSnowballValue;
                    bestSnowballSnow = snowballSnow;
                    bestSnowballTime = snowballTime;
                    bestSnowballQuality = snowballQuality;
                }
            }
            Console.WriteLine($"{bestSnowballSnow} : {bestSnowballTime} = {biggestSnowballValue} ({bestSnowballQuality})");
        }
    }
}
