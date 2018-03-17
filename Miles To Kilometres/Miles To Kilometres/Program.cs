using System;

namespace Miles_To_Kilometres
{
    class Program
    {
        static void Main(string[] args)
        {
            double miles = double.Parse(Console.ReadLine());

            double kilometres = 1.60934 * miles;

            Console.WriteLine("{0:f2}", kilometres);
        }
    }
}
