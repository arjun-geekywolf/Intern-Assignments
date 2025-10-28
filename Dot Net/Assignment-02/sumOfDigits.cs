using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_02
{
    internal class sumOfDigits
    {
        public void printSum(int num)
        {
            Console.WriteLine("\n\n\nSum of the digits of a number\n");
            int sum = 0;
            int lastdigit;
            while (num != 0) {
                lastdigit = num % 10;
                sum += lastdigit;
                num = num / 10;
            }
            Console.WriteLine(sum);
        }
    }
}
