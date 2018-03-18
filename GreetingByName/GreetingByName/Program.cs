using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreetingByName
{
    class Program //This is a program for greentings by name!
    {
        static void Main(string[] args)
        {

            var name = Console.ReadLine();
            Console.WriteLine("Hello, {0}!" , name);
        }
    }
}
