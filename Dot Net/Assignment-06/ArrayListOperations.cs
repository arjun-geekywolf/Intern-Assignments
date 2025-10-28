using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_06
{
    internal class ArrayListOperations
    {
        ArrayList array = new ArrayList();
        public void operations()
        {
            
            array.Add("arjun1");
            array.Add("arjun2");
            array.Add("arjun3");
            array.Add("arjun4");
            array.Add("arjun5");


            Console.WriteLine("Initial list:\n");
            printArray();
            
            array.Remove("arjun5");

            Console.WriteLine("\nList after removal \n");
            printArray();

            array.Insert(2, "arjun6");

            Console.WriteLine("\nFinal List: \n");
            for(int i =0; i < array.Count; i++)
            {
                Console.WriteLine(array[i]);
            }

        }

        public void printArray()
        {
            foreach (var item in array) {

                Console.WriteLine(item);
            }
        }
    }
}
