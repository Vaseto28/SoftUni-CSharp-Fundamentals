using System;

namespace T08.MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = double.Parse(Console.ReadLine());
            var power = int.Parse(Console.ReadLine());
            var poweredNum = PoweringTheNumber(num, power);
            Console.WriteLine(poweredNum);
        }

        static double PoweringTheNumber(double num, int power)
        {
            var poweredNum = 1.0;
            for (int i = 1; i <= power; i++)
            {
                poweredNum *= num;
            }
            return poweredNum;
        }
    }
}
