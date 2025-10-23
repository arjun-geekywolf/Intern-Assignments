using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_06
{
    internal class EmployeeCollection
    {
        List<Employee> employees = new List<Employee>();
        public void AddEmployee()
        {
            string name;
            double salary;
            string type="";
            Console.WriteLine("Enter Employee Name: ");
            name= Console.ReadLine();

            Console.WriteLine("Enter Employee Salary: ");
            if (!double.TryParse(Console.ReadLine(), out salary))
                Console.WriteLine("Enter a valid salary");

            Console.WriteLine("Enter Employee Type: \n 1.Permanent\n 2.Contract");

            if(int.TryParse(Console.ReadLine(),out int option))
            {
                if (option == 1 || option == 2)
                    type = option == 2 ? "Permanent" : "Contract";

                else
                {
                    Console.WriteLine("Enter either 1 or 2");
                }

            }
            else
            {
                Console.WriteLine("Enter a valid option");
            }

                Employee e = new Employee(name, salary, type);
                employees.Add(e);

        }



        public void RemoveEmployee()
        {
            string empId;
            Console.WriteLine("Enter employee ID: ");
            empId = Console.ReadLine();

            Employee emp = employees.FirstOrDefault(id => id.Id == empId);

            if (employees.Remove(emp))
            {
                Console.WriteLine("Employee removed");

            }
            else
            {
                Console.WriteLine("No Employee found");
            }
        }

        public void Search()
        {
            string key;
            Console.WriteLine("Enter Employee name to search: ");
            key = Console.ReadLine().ToLower();

            Employee emp = employees.Find(name => name.Name.ToLower() == key);

            if (emp != null)
            {
                emp.Display();
            }
            else
            {
                Console.WriteLine("Employee not found");
            }
            
            }

        public void DisplayAll()
        {
            Console.WriteLine("All employees");
            foreach (Employee e in employees)
            {
                e.Display();

            }

        }

    }
}
