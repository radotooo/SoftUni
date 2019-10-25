using _01.InitialSetup;
using System;
using System.Data.SqlClient;

namespace _06.RemoveVillain
{
    class Program
    {
        static void Main(string[] args)
        {
            int villianId = int.Parse(Console.ReadLine());

            var connection = new SqlConnection(Connection.MySqlConnection);

            using (connection)
            {

                connection.Open();
                var sqlTran = connection.BeginTransaction();
                var command = connection.CreateCommand();
                command.Transaction = sqlTran;

                try
                {
                    command.CommandText = @"SELECT Name FROM Villains WHERE Id = @villainId";
                    command.Parameters.AddWithValue("@villainId", villianId);
                    var currentVillian = command.ExecuteScalar();

                    if (currentVillian == null)
                    {
                        Console.WriteLine("No such villain was found.");
                        return;
                    }

                    command.CommandText = @"DELETE FROM MinionsVillains 
                                        WHERE VillainId = @villainId";
                    int deteledMinionsCount = command.ExecuteNonQuery();

                    command.CommandText = @"DELETE FROM Villains
                                        WHERE Id = @villainId";
                    command.ExecuteNonQuery();

                    Console.WriteLine($"{currentVillian} was deleted.");
                    Console.WriteLine($"{deteledMinionsCount} minions were released.");


                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                    try
                    {
                        sqlTran.Rollback();
                    }
                    catch (Exception exRollback)
                    {

                        Console.WriteLine(exRollback.Message);
                    }
                }
                

               


            }
        }
    }
}
