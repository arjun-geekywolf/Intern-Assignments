
using SQL_Connection;

DBOperations operations = new DBOperations();

Console.WriteLine("Enter Employee Id to insert:");
int insertId = int.Parse(Console.ReadLine());
Console.WriteLine("Enter Employee Name to insert:");
string insertName = Console.ReadLine();
Console.WriteLine("Enter Employee Salary to insert:");
decimal insertSalary = decimal.Parse(Console.ReadLine());
operations.InsertData(insertId, insertName, insertSalary);

Console.WriteLine("Enter Employee Id to update:");
int updateId = int.Parse(Console.ReadLine());
Console.WriteLine("Enter Employee Name to update:");
string updateName = Console.ReadLine();
Console.WriteLine("Enter Employee Salary to update:");
decimal updateSalary = decimal.Parse(Console.ReadLine());
operations.UpdateData(updateId, updateName, updateSalary);

Console.WriteLine("Enter Employee Id to delete:");
int deleteId = int.Parse(Console.ReadLine());
operations.DeleteData(deleteId);

operations.DisplayEmployeeData();
operations.DisplayEmployeeCount();
operations.RetrieveAndUpdateEmployeeData();