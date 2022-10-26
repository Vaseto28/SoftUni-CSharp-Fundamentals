using System;

namespace _09.Padawan_equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            var amountOfMoney = double.Parse(Console.ReadLine());
            var students = int.Parse(Console.ReadLine());
            var priceOfLightSaber = double.Parse(Console.ReadLine());
            var priceOfRobe = double.Parse(Console.ReadLine());
            var priceOfBelt = double.Parse(Console.ReadLine());
            var swordsForStudents = students + Math.Ceiling(0.1 * students);
            var totalPriceOfLightSabers = swordsForStudents * priceOfLightSaber;
            var totalPriceOfRobes = priceOfRobe * students;
            students -= students / 6;
            var totalPriceOfBelts = students * priceOfBelt;
            var totalPrice = totalPriceOfLightSabers + totalPriceOfRobes + totalPriceOfBelts;
            if (amountOfMoney >= totalPrice)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {Math.Abs(amountOfMoney-totalPrice):f2}lv more.");
            }
        }
    }
}
