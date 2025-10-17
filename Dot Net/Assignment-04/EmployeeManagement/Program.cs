

using EmployeeManagement;

Employee emp = new Employee("Arjun", 75000, "Permanent");
emp.DisplayEmployees();

Employee emp1 = new Employee("Arun", 80000, "Contract");
emp1.DisplayEmployees();


Console.WriteLine($"No of employees ={Employee.NumberOfEmployees()}");
Console.WriteLine($"Next Employee id = {Employee.NextEmployeeId()}");
