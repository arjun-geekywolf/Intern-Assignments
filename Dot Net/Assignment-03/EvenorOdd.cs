using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Assignment_03
{
    internal class EvenorOdd
    {
        int num;
        public EvenorOdd() {
            Console.WriteLine("\n\n\nCheck whether a number is even or odd using the ternary operator.\n");
            Console.WriteLine("Enter a Number: ");
            if(!int.TryParse(Console.ReadLine(),out num)){
                Console.WriteLine("Invalid number");
                return;
            }
            Console.WriteLine(num % 2 == 0 ? $"{num} is Even" : $"{num} is Odd");
        }
    }
}
