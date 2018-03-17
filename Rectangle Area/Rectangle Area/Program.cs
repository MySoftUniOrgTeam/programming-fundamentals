using System;

namespace Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());

            var rectangleArea = width * height;

            Console.WriteLine("{0:f2}", rectangleArea);
        }
    }
}
