using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_07
{
    public class Animal
    {
        public virtual void speak()
        {
            Console.WriteLine("Speaking");
        }

    }

    public class Dog : Animal
    {
        public override void speak()
        {

            Console.WriteLine("Bow bow");
        }
    }

    public class Cat : Animal
    {
        public override void speak()
        {
            Console.WriteLine("Meow Meow");
        }
    }


}
