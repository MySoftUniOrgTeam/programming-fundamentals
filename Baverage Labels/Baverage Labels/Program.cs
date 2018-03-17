using System;

namespace Baverage_Labels
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var volume = int.Parse(Console.ReadLine());
            var energyContent = int.Parse(Console.ReadLine());
            var sugarContent = int.Parse(Console.ReadLine());

            var energyContentGivenVolume = (volume * energyContent) / 100.0;
            var sugarContentGivenVolume = (volume * sugarContent) / 100.0;

            Console.WriteLine("{0}ml {1}:", volume, name);
            Console.WriteLine("{0}kcal, {1}g sugars", energyContentGivenVolume, sugarContentGivenVolume);
        }
    }
}
