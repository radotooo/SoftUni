using _01.InitialSetup;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace _07.PrintAllMinionNames
{
    class Program
    {
        static List<string> minionsNames = new List<string>();
        static void Main(string[] args)
        {
            var connection = new SqlConnection(Connection.MySqlConnection);

            using (connection)
            {
                connection.Open();


                string query = @"SELECT Name FROM Minions";

                var command = new SqlCommand(query, connection);
                var result = command.ExecuteReader();
                using (result)
                {
                    while (result.Read())
                    {
                        minionsNames.Add(result["Name"].ToString());
                    }
                }
                //var test = new List<string> { "Bob",
                //                              "Kevin",
                //                              "Steward",
                //                              "Jimmy",
                //                              "Vicky",
                //                              "Becky",
                //                              "Jully"};




                var output = new List<string>();
                for (int i = 0; i < minionsNames.Count / 2; i++)
                {
                    output.Add(minionsNames[i]);
                    output.Add(minionsNames[minionsNames.Count - i - 1]);
                }

                if (minionsNames.Count % 2 != 0)
                {
                    output.Add(minionsNames[minionsNames.Count / 2]);
                }

                Console.WriteLine(string.Join("\n", output));

            }
        }
    }
}




