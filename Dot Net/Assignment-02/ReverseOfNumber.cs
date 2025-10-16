using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_02
{
    internal class ReverseOfNumber
    {
  

        public void PrintReverse(int num)
        {
            Console.WriteLine("\n\n\nReverse of a number\n");
            int rev = 0;
            int lastDigit;

            while (num != 0)
            {
                lastDigit = num % 10;
                rev=(rev*10)+lastDigit;
                num = num / 10;
            }

            Console.WriteLine(rev);
        }
    }
}
