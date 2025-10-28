using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_02
{
    internal class Fibonacci
    {
        public static void PrintFibonacci(int n)
        {
            Console.WriteLine("\n\n\nFibonacci series\n");
            int first = 0;
            int second = 1;
            int next;
            for (int i = 0; i < n; i++)
            {
                if (i == 0)
                    Console.Write(first);
                else if (i == 1)
                    Console.Write(" ," + second);
                else
                {
                    next = first + second;
                    Console.Write(" ," + next);
                    first = second;
                    second = next;
                }

            }
        }
    }

}
