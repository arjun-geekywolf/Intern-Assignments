using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a method GetSumAndAverage(int a, int b, out int sum, out double avg) that returns sum and average using out parameters.

namespace Assignment_03
{
    internal class GetSumAndAvg
    {

    public void SumAndAvg(int a,int b, out int sum, out double avg)
        {
            sum = a + b;
            avg = Convert.ToDouble(sum) / 2;
        }
    
    }
}
