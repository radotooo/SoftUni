using _01.InitialSetup;
using System;
using System.Data;
using System.Data.SqlClient;

namespace _09.IncreaseAgeStoredProcedure
{
    class Program
    {
        static void Main(string[] args)
        {

            int input = int.Parse(Console.ReadLine());

            var connection = new SqlConnection(Connection.MySqlConnection);
            using (connection)
            {
                connection.Open();
                var command = new SqlCommand("usp_GetOlder",connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Id", input);
                command.ExecuteNonQuery();
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT Name, Age FROM Minions WHERE Id = @Id";
                var reader = command.ExecuteReader();

                using (reader)
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"{reader["Name"]} - {reader["Age"]} years old");
                    }
                }


            }
        }
    }
}
