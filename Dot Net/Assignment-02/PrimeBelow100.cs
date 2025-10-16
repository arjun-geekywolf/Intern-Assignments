using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_02
{
    internal class PrimeBelow100
    {
        PrimeCheck primecheck = new PrimeCheck();

        public void PrintPrimes()
        {
            Console.WriteLine("\n\n\nPrint all prime numbers below 100\n");

            for (int i = 0; i < 100; i++)
            {
                if (primecheck.IsPrime(i))
                    Console.WriteLine(i);
            }
        }
    }
}
