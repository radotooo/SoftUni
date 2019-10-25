using _01.InitialSetup;
using System;
using System.Data.SqlClient;

namespace _03.MinionNames
{
    class Program
    {
        static void Main(string[] args)
        {
            var connection = new SqlConnection(Connection.MySqlConnection);

            using (connection)
            {
                connection.Open();
                int getVillianId = int.Parse(Console.ReadLine());
                string query = $@"SELECT Name FROM Villains WHERE Id = {getVillianId}";

                var selectVillianWithCurrentId = new SqlCommand(query, connection);
                var resultVillian = selectVillianWithCurrentId.ExecuteScalar();
                if (resultVillian == null)
                {
                    Console.WriteLine($"No villain with ID {getVillianId} exists in the database.");
                    return;
                }

                Console.WriteLine($"Villain: {resultVillian.ToString()}");

                string query2 = $@"SELECT ROW_NUMBER() OVER (ORDER BY m.Name) as RowNum,
                                         m.Name, 
                                         m.Age
                                    FROM MinionsVillains AS mv
                                    JOIN Minions As m ON mv.MinionId = m.Id
                                   WHERE mv.VillainId = {getVillianId}
                                ORDER BY m.Name";
                var selectCurrentVillianMinions = new SqlCommand(query2, connection);

                
                var resultMinions = selectCurrentVillianMinions.ExecuteReader();
               
                using (resultMinions)
                {
                    if (!resultMinions.Read())
                    {
                        Console.WriteLine($"(no minions)");
                        return;
                    }

                    int counter = 0;
                    while (resultMinions.Read())
                    {
                        counter++;
                        Console.WriteLine($"{counter}. {resultMinions[1]} {resultMinions[2]}");

                    }
                }





            }

        }
    }
}
