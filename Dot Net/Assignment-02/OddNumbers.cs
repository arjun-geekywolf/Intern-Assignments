using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_02
{
    internal class OddNumbers
    {
        public static void PrintNumbers()
        {
            Console.WriteLine("\n\n\nOdd numbers less than 50 \n");
            int i = 1;
            while (i <= 50)
            {
                if(i%2 != 0)
                    Console.WriteLine(i);
                i++;
            }
        }
    }
}
