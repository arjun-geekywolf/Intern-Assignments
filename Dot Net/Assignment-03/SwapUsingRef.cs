using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Swap two integers using the ref keyword.

namespace Assignment_03
{
    internal class SwapUsingRef
    {
        public void Swap(ref int num1, ref int num2)
        {
            Console.WriteLine($"Before Swap: Num1 = {num1} Num2 = {num2}");
            (num1, num2) = (num2, num1);
            Console.WriteLine($"After Swap: Num1 = {num1} Num2 = {num2}");
        }
    }
}
