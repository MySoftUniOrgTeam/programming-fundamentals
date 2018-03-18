using System;

namespace Debit_Card_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var First = int.Parse(Console.ReadLine()); // read the input 
            var Second = int.Parse(Console.ReadLine());
            var Third = int.Parse(Console.ReadLine());
            var Forth = int.Parse(Console.ReadLine());

            Console.WriteLine("{0:d4} {1:d4} {2:d4} {3:d4}", First, Second, Third, Forth); // out the result 
        }
    }
}
