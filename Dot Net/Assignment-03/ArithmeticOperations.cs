using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_03
{
    
    internal class ArithmeticOperations
    {

        double num1, num2;

        public void Operations()
        {

            Console.WriteLine("Input two numbers and perform all arithmetic operations (+, -, *, /, %).\n");

            Console.WriteLine("Enter First Number: ");
            if (!double.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Invalid number");
                return;
            }
            Console.WriteLine("Enter Second Number: ");
            if (!double.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Invalid number");
                return;
            }

            double Add()
            {
                return num1 + num2;
            }

            double Sub()
            {
                return num1 - num2;
            }

            double mul()
            {
                return num1 * num2;
            }

            double div()
            {
                return num1 / num2;

            }

            double mod() {

                return num1 % num2;
            }

            Console.WriteLine(num1 + "+" + num2 + "=" + Add());
            Console.WriteLine(num1 + "-" + num2 + "=" +Sub());
            Console.WriteLine(num1 + "x" + num2 + "=" + mul());
            Console.WriteLine(num1 + "/" + num2 + "=" + div());
            Console.WriteLine(num1 + "%" + num2 + "=" + mod());


        }

    }
}
