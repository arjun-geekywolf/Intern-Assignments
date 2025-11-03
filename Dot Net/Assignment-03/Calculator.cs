using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_03
{
    internal class Calculator
    {

        public Calculator() {

            Console.WriteLine("\n\n\nSimulate a simple calculator using a switch statement and arithmetic operators.\n");

            double num1, num2;
            string operation;

            Console.Write("Enter the first number: ");
            if (!double.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Invalid input");
            }

            Console.Write("Enter the operator ");
            operation = Console.ReadLine();

            Console.Write("Enter the second number: ");
            if (!double.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Invalid input");
                return;
            }

            double result = 0;

            switch (operation)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Division by zero is not possble");
                        return;
                    }
                    break;
                case "%":
                    if (num2 != 0)
                    {
                        result = num1 % num2;
                    }
                    else
                    {
                        Console.WriteLine("Modulo by zero is not possible.");
                        return;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operator");
                    return;
                    break;
            }
                Console.WriteLine($"Result: {num1} {operation} {num2} = {result}");
            

        }
    }
}
