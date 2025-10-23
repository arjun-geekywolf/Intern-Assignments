using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_06
{
    internal class MixedDataTypes
    {
        ArrayList array = new ArrayList();
        public void mixed()
        {
            array.Add("john");
            array.Add(25);
            array.Add(75.5);
            array.Add(true);


            foreach (var item in array)
            {   
                Console.WriteLine($"Value: {item} Type: {item.GetType().Name}");
            }
        }

        
    }
}
