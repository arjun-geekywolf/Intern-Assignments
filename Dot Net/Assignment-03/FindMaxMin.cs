using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_03
{
    internal class FindMaxMin
    {
        public void MaxMin(int[] arr,out int min,out int max) {

            Array.Sort(arr);
            min= arr[0];
            max = arr[arr.Length - 1];

        }
    }
}
