using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_03
{
    internal class CheckBetween10and50
    {
        int num1;
        public CheckBetween10and50() {

            Console.WriteLine("\n\n\nCheck if a number lies between 10 and 50 using logical operators.\n");

            Console.WriteLine("Enter the number: ");
            if (!int.TryParse(Console.ReadLine(), out num1)) Console.WriteLine("invalid number");

            if(num1 >10 && num1 < 50)
                Console.WriteLine($"{num1} is between 10 and 50");
            else
                Console.WriteLine($"{num1} is not between 10 and 50");



        }

    }
}
