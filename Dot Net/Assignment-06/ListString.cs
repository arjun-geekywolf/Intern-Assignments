using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_06
{
    internal class ListString
    {
        List<String> names = new List<String>();
        public ListString()
        {

            names.Add("Arya");
            names.Add("Jon");
            names.Add("Daenerys");
            names.Add("Tyrion");
            names.Add("Jaime");
            names.Add("Cersi");

            Console.WriteLine("All names");
            display(names);
        }

        public void display(List<string> str)
        {
            foreach (String name in str)
            {
                Console.WriteLine(name);
            }
        }


        public void namesStartWithA()
        {
            List<String> namesStartWithA = names.Where(name => name.StartsWith("J")).ToList();

            Console.WriteLine("\nNames start with 'A'");
            display(namesStartWithA);
        }


        public void lengthGreaterThan4()
        {
            List<string> lenthGreaterThan4 = names.Where(name=>name.Length>4).ToList();
            Console.WriteLine("\nNames with Length Greater Than 4");
            display(lenthGreaterThan4);
        }

    }

}
