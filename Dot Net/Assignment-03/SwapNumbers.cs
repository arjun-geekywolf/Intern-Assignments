using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_03
{
    internal class SwapNumbers
    {
        int num1, num2;
        public SwapNumbers() {

            Console.WriteLine("\n\n\nSwap two numbers without using a third variable (use arithmetic)\n");

            Console.WriteLine("Enter first number: ");
            if (!int.TryParse(Console.ReadLine(), out num1)) Console.WriteLine("invalid number"); ;
            Console.WriteLine("Enter second number: ");
            if (!int.TryParse(Console.ReadLine(), out num2)) Console.WriteLine("invalid number");

            num1 = num1 + num2;
            num2 = num1 - num2;
            num1 = num1 - num2;

            Console.WriteLine($"num1={num1} num2={num2}");

        }
    }
}
