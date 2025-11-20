using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorWithException
{
    internal class Calculator
    {
        public void Add(int num1, int num2)
        {
            Console.WriteLine($"num1+num2 = {num1 + num2}");
        }

        public void Sub(int num1, int num2) {
            Console.WriteLine($"num1-num2 = {num1 - num2}");
        }

        public void Mult(int num1, int num2) {
            Console.WriteLine($"num1*num = {num1 * num2}");
                }

        public void Div(int num1, int num2) {
            if (num2 == 0)
                throw new DivideByZeroException("Division by zero is not possible");
            Console.WriteLine($"num1/num2 = {num1 / num2}");
        }
    }
}
