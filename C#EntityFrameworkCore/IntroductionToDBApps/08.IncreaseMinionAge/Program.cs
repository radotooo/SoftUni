using _01.InitialSetup;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace _08.IncreaseMinionAge
{
    class Program
    {
        static void Main(string[] args)
        {
            var connection = new SqlConnection(Connection.MySqlConnection);
            
            var resultTable = new Hashtable();

            int[] idList = Console.ReadLine()
                            .Split()
                            .Select(int.Parse)
                            .ToArray();
        
            using (connection)
            {
                connection.Open();

                //var sqlTran = connection.BeginTransaction();
                //var command = connection.CreateCommand();
                //command.Transaction = sqlTran;
                string query = "";

                foreach (var id in idList)
                {
                    query = $@"  UPDATE Minions
                                  SET Name = UPPER(LEFT(Name, 1)) + SUBSTRING(Name, 2, LEN(Name)), Age += 1
                                WHERE Id = {id}";
                    var command = new SqlCommand(query, connection);
                    var c = command.ExecuteScalar();
                   
                }

                query = $@"  SELECT Name, Age FROM Minions ";
                var execute = new SqlCommand(query, connection);
                var reader = execute.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        Console.WriteLine((string)reader["Name"]+" "+(int)reader["Age"]);
                    }
                }

               
            }


        }
    }
}

                            
           

