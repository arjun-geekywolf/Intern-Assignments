using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    internal class Employee
    {
        private static int counter;

        public string Id { get; private set; }
        public string Name { get;set; }
        public double Salary { get; set; }  
        public string EmployeeType { get; set; }

        static Employee()
        {
            counter = 1000;
            
        }

        public Employee(string name, double salary, string employeeType)
        {
            Id = $"EMP{counter++}";
            Name = name;
            Salary = salary;
            EmployeeType = employeeType;
        }

        public void DisplayEmployees()
        {
            Console.WriteLine($"EmpId: {Id}\nName: {Name}\nSalary:{Salary}\nEmpType: {EmployeeType} \n\n");
        }

        public static int  NumberOfEmployees()
        {
            return counter - 1000;
        }

        public static int NextEmployeeId()
        {
            return counter;
        }
    }
}
