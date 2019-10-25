using _01.InitialSetup;
using System;
using System.Data.SqlClient;
using System.Linq;

namespace _04.AddMinion
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var minionInfo = Console.ReadLine().Split();
            var villianInfo = Console.ReadLine().Split();
            
            var villianName = villianInfo[1];

            var mName = minionInfo[1];
            var mAge = int.Parse(minionInfo[2]);
            var mCity = minionInfo[3];
            

            using (var connection = new SqlConnection(Connection.MySqlConnection))
            {
                connection.Open();
                SqlTransaction sqlTran = connection.BeginTransaction();
                SqlCommand command = connection.CreateCommand();
                command.Transaction = sqlTran;

               
                try
                {
                   
                    command.CommandText = $"SELECT Id FROM Towns WHERE Name = @town";
                    command.Parameters.AddWithValue("@town", mCity);
                    
                    if (command.ExecuteScalar() == null)
                    {
                        command.CommandText = @"INSERT INTO Towns (Name) VALUES (@town)";
                        command.ExecuteNonQuery();
                        Console.WriteLine($"Town {mCity} was added to the database.");
                    }


                    command.CommandText = $"SELECT Id FROM Villains WHERE Name = @vName";
                    command.Parameters.AddWithValue("@vName", villianName);
                    
                    if (command.ExecuteScalar() == null)
                    {
                        command.CommandText = @"INSERT INTO Villains (Name, EvilnessFactorId)  VALUES (@vName, 4)";
                        command.ExecuteNonQuery();
                        Console.WriteLine($"Villain {villianName} was added to the database.");

                    }


                    command.CommandText =  $"SELECT Id FROM Towns WHERE Name = @town";
                    int townId = (int)command.ExecuteScalar();

                    command.CommandText = $"SELECT Id FROM Villains WHERE Name = @vName";
                    int villianId = (int)command.ExecuteScalar();

                    command.CommandText = $"INSERT INTO Minions (Name, Age, TownId) VALUES (@mName, @mAge, @townId)";
                    command.Parameters.AddWithValue("@mName", mName);
                    command.Parameters.AddWithValue("@mAge", mAge);
                    command.Parameters.AddWithValue("@townId", townId);
                    command.ExecuteNonQuery();


                    command.CommandText = $"SELECT Id FROM Minions WHERE Name = (@mName)";
                   int minionId = (int)command.ExecuteScalar();

                    command.CommandText = $"INSERT INTO MinionsVillains (MinionId, VillainId) VALUES (@mId, @vId)";
                    command.Parameters.AddWithValue("@mId", minionId);
                    command.Parameters.AddWithValue("@vId", villianId);
                    command.ExecuteNonQuery();

                    sqlTran.Commit();
                    Console.WriteLine($"Successfully added {mName} to be minion of {villianName}.");

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






                   


                   
                    
                        



                




