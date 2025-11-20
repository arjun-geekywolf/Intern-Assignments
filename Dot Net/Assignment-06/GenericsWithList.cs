using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_06
{
    internal class GenericsWithList
    {

        public void generics()
        {
           List<int> marks = new() { 78, 92, 67, 88, 95 };

            
            double average = marks.Average();

            Console.WriteLine("Avg = "+average);

            marks.Remove(marks.Min());
            
            marks.Sort();

            foreach (int i in marks)
            {
                Console.WriteLine(i);
            }
        }
    }
}
