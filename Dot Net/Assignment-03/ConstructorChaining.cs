using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

//Create a class Employee with two constructors (Name only; Name, Salary) using constructor chaining.

namespace Assignment_03
{
    internal class Employee
    {
        int salary { get; set; }
        string name { get; set; }
        public Employee(string name)
        {
            this.name = name;
            Console.WriteLine("one para constructor called");
        }
        public Employee(string name, int salary):this(name) { 
            this.salary = salary;
            Console.WriteLine("two para constructor called");
        }

        public void Display()
        {
            Console.WriteLine($"Name: {name}\nSalary: {salary}");
        }
    }
}
