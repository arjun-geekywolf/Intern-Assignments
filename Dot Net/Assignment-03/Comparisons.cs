using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_03
{
    internal class Comparisons
    {
        int num1, num2;
        
        public Comparisons()
        {

            Console.WriteLine("\n\n\nCompare two integers using relational and logical operators.\n");

            Console.WriteLine("Enter first number: ");
            if (!int.TryParse(Console.ReadLine(), out num1)) Console.WriteLine("invalid number"); ;
            Console.WriteLine("Enter second number: ");
            if (!int.TryParse(Console.ReadLine(), out num2)) Console.WriteLine("invalid number");

            Console.WriteLine($"{num1}>{num2} : {num1>num2}");
            Console.WriteLine($"{num1}<{num2} : {num1<num2}");
            Console.WriteLine($"{num1}<={num2} : {num1 <= num2}");
            Console.WriteLine($"{num1}>={num2} : {num1 <= num2}");
            Console.WriteLine($"{num1}={num2} : {num1 == num2}");
            Console.WriteLine($"{num1}!={num2} : {num1 != num2}");
            Console.WriteLine($"{num1}>10 AND {num2}>10 : {num1 > 10 && num2 > 10}");
            Console.WriteLine($"{num1}>10 OR {num2}>10 : {num1 > 10 || num2 > 10}");

        }

    }
}
