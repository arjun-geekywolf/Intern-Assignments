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
            Display(names);
        }

        public void Display(List<string> str)
        {
            foreach (String name in str)
            {
                Console.WriteLine(name);
            }
        }


        public void NamesStartWithA()
        {
            List<String> namesStartWithA = names.Where(name => name.StartsWith("A")).ToList();

            Console.WriteLine("\nNames start with 'A'");
            Display(namesStartWithA);
        }


        public void LengthGreaterThanFour()
        {
            List<string> lengthGreaterThanFour = names.Where(name=>name.Length>4).ToList();
            Console.WriteLine("\nNames with Length Greater Than 4");
            Display(lengthGreaterThanFour);
        }

    }

}
