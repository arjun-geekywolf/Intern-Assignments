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
           List<int> marks = new List<int>();

            marks.Add(78);
            marks.Add(92);
            marks.Add(67);
            marks.Add(88);
            marks.Add(95);

            
            double avg=marks.Average();

            Console.WriteLine("Avg = "+avg);

            marks.Remove(marks.Min());
            
            marks.Sort();

            foreach (int i in marks)
            {
                Console.WriteLine(i);
            }
        }
    }
}
