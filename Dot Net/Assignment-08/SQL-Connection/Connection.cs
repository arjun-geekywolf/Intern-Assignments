using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Connection
{
    public class DBOperations
    {
        string connString = @"Data Source=localhost,1433;User ID=sa;Password=arjun@123;Trust Server Certificate=True";

        public void InsertData()
        {
            using (SqlConnection connection = new SqlConnection(connString))
            {
                try
                {
                    connection.Open();
                    string insertQuery = "INSERT INTO Employee (Id, Name, Salary) VALUES (@Id, @Name, @Salary)";
                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Id", 101);
                        command.Parameters.AddWithValue("@Name", "Arjun");
                        command.Parameters.AddWithValue("@Salary", 20000);
                        int rowsAffected = command.ExecuteNonQuery();
                        Console.WriteLine($"{rowsAffected} row added");

                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("@Id", 102);
                        command.Parameters.AddWithValue("@Name", "Anand");
                        command.Parameters.AddWithValue("@Salary", 30000);
                        rowsAffected = command.ExecuteNonQuery();
                        Console.WriteLine($"{rowsAffected} row added");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        public void UpdateData()
        {
            using (SqlConnection connection = new SqlConnection(connString))
            {
                try
                {
                    connection.Open();
                    string updateQuery = "UPDATE Employee SET Name = @Name, Salary = @Salary WHERE Id = @Id";
                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Id", 101);
                        command.Parameters.AddWithValue("@Name", "Arjun C Vinod");
                        command.Parameters.AddWithValue("@Salary", 50000);
                        int rowsAffected = command.ExecuteNonQuery();
                        Console.WriteLine($"{rowsAffected} row updated");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        public void DeleteData()
        {
            using (SqlConnection connection = new SqlConnection(connString))
            {
                try
                {
                    connection.Open();
                    string deleteQuery = "DELETE FROM Employee WHERE Id = @Id";
                    using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Id", 102);
                        int rowsAffected = command.ExecuteNonQuery();
                        Console.WriteLine($"{rowsAffected} row deleted");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        public void DisplayEmployeeData()
        {
            using (SqlConnection connection = new SqlConnection(connString))
            {
                try
                {
                    connection.Open();
                    string selectQuery = "SELECT Id, Name, Salary FROM Employee";
                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            Console.WriteLine($"{"Id"} {"Name"} {"Salary"}");

                            if (!reader.HasRows)
                            {
                                Console.WriteLine("No data found");
                            }
                            else
                            {
                                while (reader.Read())
                                {
                                    Console.WriteLine($"{reader["Id"]} {reader["Name"]} {reader["Salary"]}");
                                }
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Error reading data: {e.Message}");
                }
            }
        }

        public void DisplayEmployeeCount()
        {
            using (SqlConnection connection = new SqlConnection(connString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM Employee";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        object result = command.ExecuteScalar();
                        Console.WriteLine($"Total number of employees: {result}");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        public void RetrieveAndUpdateEmployeeData()
        {
            using (SqlConnection connection = new SqlConnection(connString))
            {
                try
                {
                    string selectQuery = "SELECT Id, Name, Salary FROM Employee";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, connection))
                    {
                        DataSet dataSet = new DataSet();
                        adapter.Fill(dataSet, "Employee");

                        Console.WriteLine("\nInitial Employee Data:");
                        DisplayData(dataSet);

                        DataTable employeeTable = dataSet.Tables["Employee"];
                        if (employeeTable.Rows.Count > 0)
                        {
                            employeeTable.Rows[0]["Salary"] = 75000;
                            employeeTable.Rows[0].AcceptChanges();
                            employeeTable.Rows[0]["Salary"] = 80000;
                        }

                        DataRow newRow = employeeTable.NewRow();
                        newRow["Id"] = 103;
                        newRow["Name"] = "Akshay";
                        newRow["Salary"] = 70000;
                        employeeTable.Rows.Add(newRow);

                        Console.WriteLine("\nEmployee Data After updation:");
                        DisplayData(dataSet);

                        ConfigureAdapterCommands(adapter);

                        connection.Open();
                        int rowsAffected = adapter.Update(dataSet, "Employee");
                        Console.WriteLine($"\n{rowsAffected} row updated");

                        dataSet.Clear();
                        adapter.Fill(dataSet, "Employee");
                        Console.WriteLine("\nEmployee Data in Database:");
                        DisplayData(dataSet);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        private void DisplayData(DataSet dataSet)
        {
            DataTable table = dataSet.Tables["Employee"];

            Console.WriteLine($"{"Id    "} {"Name      "} {"Salary       "}");

            if (table.Rows.Count == 0)
            {
                Console.WriteLine("No data found in the Employee table.");
            }
            else
            {
                foreach (DataRow row in table.Rows)
                {
                    Console.WriteLine($"{row["Id"]} {row["Name"]} {Convert.ToDecimal(row["Salary"])}");
                }
            }
        }

        private void ConfigureAdapterCommands(SqlDataAdapter adapter)
        {
            adapter.UpdateCommand = new SqlCommand(
                "UPDATE Employee SET Name = @Name, Salary = @Salary WHERE Id = @Id", adapter.SelectCommand.Connection);
            adapter.UpdateCommand.Parameters.Add("@Name", SqlDbType.VarChar, 50, "Name");
            adapter.UpdateCommand.Parameters.Add("@Salary", SqlDbType.Decimal, 0, "Salary");
            SqlParameter idParam = adapter.UpdateCommand.Parameters.Add("@Id", SqlDbType.Int, 0, "Id");
            idParam.SourceVersion = DataRowVersion.Original;

            adapter.InsertCommand = new SqlCommand(
                "INSERT INTO Employee (Id, Name, Salary) VALUES (@Id, @Name, @Salary)", adapter.SelectCommand.Connection);
            adapter.InsertCommand.Parameters.Add("@Id", SqlDbType.Int, 0, "Id");
            adapter.InsertCommand.Parameters.Add("@Name", SqlDbType.VarChar, 50, "Name");
            adapter.InsertCommand.Parameters.Add("@Salary", SqlDbType.Decimal, 0, "Salary");
        }
    }
}