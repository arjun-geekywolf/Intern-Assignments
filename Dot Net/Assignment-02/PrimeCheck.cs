using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_02
{
    internal class PrimeCheck
    {
        public bool  IsPrime(int num)
        {
           
            if (num<2)
                return false;

            for (int i = 2; i < num; i++) {

                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
