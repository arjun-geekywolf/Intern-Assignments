using System;
using System.Data;
using Microsoft.Data.SqlClient;


public class Students
{
    string connectionString= @"Data Source=localhost,1433;Database=studentDB;User ID=sa;Password=arjun@123;Trust Server Certificate=True";

 

    // Question 6
    public void InsertStudentInline(string name, string className)
    {
        using (SqlConnection conn = new SqlConnection(this.connectionString))
        {
            string query = "INSERT INTO Student (Name, Class) VALUES (@Name, @Class)";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Class", className);

                try
                {
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    Console.WriteLine("Student inserted successfully");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }

    // Question 7
    public void GetStudentById(int studentId)
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            using (SqlCommand cmd = new SqlCommand("GetStudentById", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@StudentId", studentId);

                try
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Console.WriteLine($"GetStudentById: ID: {reader["Id"]}, Name: {reader["Name"]}, Class: {reader["Class"]}");
                        }
                        else
                        {
                            Console.WriteLine("Not found");
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }

    // Question 8
    public void InsertStudent(string name, string className)
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            using (SqlCommand cmd = new SqlCommand("InsertStudent", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Class", className);
                SqlParameter outputParam = new SqlParameter("@LastInsertedId", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(outputParam);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    int lastInsertedId = (int)cmd.Parameters["@LastInsertedId"].Value;
                    Console.WriteLine("Student inserted ");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"InsertStudent Error: {ex.Message}");
                }
            }
        }
    }

    // Question 9
    public void DeleteStudent(int studentId)
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            using (SqlCommand cmd = new SqlCommand("DeleteStudent", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@StudentId", studentId);

                try
                {
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Student deleted");
                    }
                    else
                    {
                        Console.WriteLine("student not found");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }

    // Question 10
    public void UpdateStudent(int studentId, string name, string className)
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            using (SqlCommand cmd = new SqlCommand("UpdateStudent", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@StudentId", studentId);
                cmd.Parameters.AddWithValue("@StudentName", name);
                cmd.Parameters.AddWithValue("@Class", className);

                try
                {
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Student with updated successfully");
                    }
                    else
                    {
                        Console.WriteLine("student not found");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}