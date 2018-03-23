using System;

namespace Debit_Card_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int First = int.Parse(Console.ReadLine()); // read the input 
            int Second = int.Parse(Console.ReadLine());
            int Third = int.Parse(Console.ReadLine());
            int Forth = int.Parse(Console.ReadLine());

            Console.WriteLine($"{First:d4} {Second:d4} {Third:d4} {Forth:d4}"); // out the result ; I'll be used interpolation !
        }
    }
}
