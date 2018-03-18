using System;

namespace Baverage_Labels
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine(); // reading the input from the console 
            var volume = int.Parse(Console.ReadLine());
            var energyContent = int.Parse(Console.ReadLine());
            var sugarContent = int.Parse(Console.ReadLine());

            var energyContentGivenVolume = (volume * energyContent) / 100.0; // calculate 
            var sugarContentGivenVolume = (volume * sugarContent) / 100.0;

            Console.WriteLine("{0}ml {1}:", volume, name); // use place holders to out the result 
            Console.WriteLine("{0}kcal, {1}g sugars", energyContentGivenVolume, sugarContentGivenVolume);
        }
    }
}
