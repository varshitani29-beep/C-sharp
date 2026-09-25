using System;
using System.Data;
using Microsoft.Data.Sqlite;

class Program
{
    static void Main()
    {
        string connectionString = "Data Source=students.db";

        // Create database and table
        using (SqliteConnection connection =
               new SqliteConnection(connectionString))
        {
            connection.Open();

            string createTable = @"
                CREATE TABLE IF NOT EXISTS Students
                (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT NOT NULL,
                    Department TEXT NOT NULL,
                    Mark INTEGER
                )";

            using (SqliteCommand command =
                   new SqliteCommand(createTable, connection))
            {
                command.ExecuteNonQuery();
            }

            // Insert student data
            string insertData = @"
                INSERT INTO Students (Name, Department, Mark)
                SELECT 'Arun', 'IT', 85
                WHERE NOT EXISTS
                (
                    SELECT 1 FROM Students WHERE Name = 'Arun'
                );

                INSERT INTO Students (Name, Department, Mark)
                SELECT 'Priya', 'CSE', 90
                WHERE NOT EXISTS
                (
                    SELECT 1 FROM Students WHERE Name = 'Priya'
                );

                INSERT INTO Students (Name, Department, Mark)
                SELECT 'Kumar', 'ECE', 78
                WHERE NOT EXISTS
                (
                    SELECT 1 FROM Students WHERE Name = 'Kumar'
                );
            ";

            using (SqliteCommand command =
                   new SqliteCommand(insertData, connection))
            {
                command.ExecuteNonQuery();
            }
        }

        // Create DataSet
        DataSet dataSet = new DataSet();

        // Retrieve data from database
        using (SqliteConnection connection =
               new SqliteConnection(connectionString))
        {
            connection.Open();

            string query =
                "SELECT Id, Name, Department, Mark FROM Students";

            using (SqliteCommand command =
                   new SqliteCommand(query, connection))
            {
                using (SqliteDataReader reader =
                       command.ExecuteReader())
                {
                    DataTable table = new DataTable("Students");

                    table.Columns.Add("Id", typeof(int));
                    table.Columns.Add("Name", typeof(string));
                    table.Columns.Add("Department", typeof(string));
                    table.Columns.Add("Mark", typeof(int));

                    while (reader.Read())
                    {
                        DataRow row = table.NewRow();

                        row["Id"] = reader.GetInt32(0);
                        row["Name"] = reader.GetString(1);
                        row["Department"] = reader.GetString(2);
                        row["Mark"] = reader.GetInt32(3);

                        table.Rows.Add(row);
                    }

                    dataSet.Tables.Add(table);
                }
            }
        }

        // Display DataSet information
        Console.WriteLine("Database connection closed.");
        Console.WriteLine("Data is now available in the DataSet.");
        Console.WriteLine();

        DataTable students = dataSet.Tables["Students"];

        Console.WriteLine("STUDENT DETAILS");
        Console.WriteLine("---------------------------------------------");

        foreach (DataRow row in students.Rows)
        {
            Console.WriteLine(
                "ID: " + row["Id"] +
                " | Name: " + row["Name"] +
                " | Department: " + row["Department"] +
                " | Mark: " + row["Mark"]
            );
        }

        Console.WriteLine("---------------------------------------------");
        Console.WriteLine();

        // Display students with marks greater than 80
        Console.WriteLine("Students with marks greater than 80:");

        foreach (DataRow row in students.Rows)
        {
            int mark = Convert.ToInt32(row["Mark"]);

            if (mark > 80)
            {
                Console.WriteLine(
                    row["Name"] + " - " +
                    row["Department"] + " - " +
                    row["Mark"]
                );
            }
        }

        Console.WriteLine();
        Console.WriteLine("Program completed successfully.");
    }
}