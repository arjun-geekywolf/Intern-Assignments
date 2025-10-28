using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_06
{
    internal class Employee
    {

        public String Id;
        public string Name;
        double Salary;
        string EmployeeType;
        static int counter = 1000;

    
    
        public Employee(string name, double salary, string employeeType)
        {
            Id = "EMP"+counter++ ;
            Name = name;
            Salary = salary;
            EmployeeType = employeeType;
        }


        public void Display()
        {
            Console.WriteLine($"ID: {Id}\nName: {Name}\nSalary: {Salary}\nType: {EmployeeType}\n\n");
        }
    }
}
