﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Stats
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine(); // reading the input from the console 
            var currentHealth = int.Parse(Console.ReadLine());
            var maxHealth = int.Parse(Console.ReadLine());
            var currentEnergy = int.Parse(Console.ReadLine());
            var maxEnergy = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Health: {'|' + new string('|', currentHealth) + new string('.', (maxHealth - currentHealth)) + '|'}"); // use place holders to our the result 
            Console.WriteLine($"Energy: {'|' + new string('|', currentEnergy) + new string('.', (maxEnergy - currentEnergy)) + '|'}");
        }
    }
}
