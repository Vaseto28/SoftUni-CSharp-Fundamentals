using System;

namespace T06.CalculatingRectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            var width = int.Parse(Console.ReadLine());
            var length = int.Parse(Console.ReadLine());
            var area = CalculatingRectangleArea(width, length);
            Console.WriteLine(area);
        }

        static int CalculatingRectangleArea(int width, int length)
        {
            var area = width * length;
            return area;
        }

        //Alternative way
        //static void Main(string[] args)
        //{
        //    var width = int.Parse(Console.ReadLine());
        //    var length = int.Parse(Console.ReadLine());
        //    CalculatingRectangleArea(width, length);
        //}

        //static void CalculatingRectangleArea(int width, int length)
       //{
        //    var sum = width * length;
        //    Console.WriteLine(sum);
        //}

    }
}
