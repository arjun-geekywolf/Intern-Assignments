using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_07
{
    public static class AverageExceptZeroExtension
    {

        public static double AverageExceptZero(this List<int> numbers)

        {
            int count = 0;
            int sum = 0;
            foreach (var item in numbers) {

                if (item == 0) continue;
                sum += item;
                count++;
            }

            if(count==0)
                return 0;
            return (double)sum / count;
        }
    }

}
