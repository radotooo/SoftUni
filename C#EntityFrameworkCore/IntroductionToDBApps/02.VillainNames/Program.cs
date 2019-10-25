using _01.InitialSetup;
using System;
using System.Data.SqlClient;

namespace _02.VillainNames
{
    class Program
    {
        

        static void Main(string[] args)
        {
            var sqlCon = new SqlConnection(Connection.MySqlConnection);

            using (sqlCon)
            {
                sqlCon.Open();

                string query = @"  SELECT v.Name, COUNT(mv.VillainId) AS MinionsCount  
                                            FROM Villains AS v
                                            JOIN MinionsVillains AS mv ON v.Id = mv.VillainId
                                        GROUP BY v.Id, v.Name
                                          HAVING COUNT(mv.VillainId) > 3
                                        ORDER BY COUNT(mv.VillainId)";
                var executSqlCon = new SqlCommand(query, sqlCon);
                var reader = executSqlCon.ExecuteReader();

                using (reader)
                {

                    while (reader.Read())
                    {
                        Console.WriteLine(reader["Name"] + " - " + reader["MinionsCount"]);
                    }
                }
            }
        }
    }
}
