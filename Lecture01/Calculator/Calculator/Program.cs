using System;
using System.Collections.Generic;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var calc = new Calculator();

            Console.WriteLine($"1 + 2 = {calc.Add(1,2)}");
            Console.WriteLine($"1 - 2 = {calc.Subtract(1, 2)}");
            Console.WriteLine($"2 * 3 = {calc.Multiply(2, 3)}");
            Console.WriteLine($"2^3 = {calc.Power(2, 3)}");

        }
    }
}
