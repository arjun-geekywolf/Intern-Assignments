using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_02
{
    internal class LargestNumber
    {
        int large;

        public void Printlargest(int num1, int num2, int num3)
        {
            Console.WriteLine("\n\n\nLarge amoung 3 numbers\n");

            if (num1 > num2 && num1 > num3)
                large = num1;
            else if (num2 > num3)
                large = num2;
            else
                large = num3;

            Console.WriteLine("Largest Number is " + large);
           
        }

        

    }
}
