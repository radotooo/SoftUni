using _01.InitialSetup;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace _05.ChangeTownNamesCasing
{
    class Program
    {
        public static  List<string> affectedTowns = new List<string>();
        static void Main(string[] args)
        {
            string countryName = Console.ReadLine();
            var connection = new SqlConnection(Connection.MySqlConnection);



            using (connection)
            {

                connection.Open();
                SqlTransaction sqlTran = connection.BeginTransaction();
                SqlCommand command = connection.CreateCommand();
                command.Transaction = sqlTran;

                try
                {
                    command.CommandText = @" SELECT t.Name 
                                  FROM Towns as t
                                  JOIN Countries AS c ON c.Id = t.CountryCode
                                 WHERE c.Name = @countryName";
                    command.Parameters.AddWithValue("@countryName", countryName);
                    var countryExist = command.ExecuteScalar();

                    if (countryExist == null)
                    {
                        Console.WriteLine("No town names were affected.");
                        return;
                    }

                    //Get towns in current country and add them to list.
                    var reader = command.ExecuteReader();
                    using (reader)
                    {
                        while (reader.Read())
                        {
                            affectedTowns.Add(reader["Name"].ToString());
                        }
                    }

                    //Update selected towns names in current country to upper case.
                    command.CommandText = @"UPDATE Towns
                                           SET Name = UPPER(Name)
                                           WHERE CountryCode = (SELECT c.Id FROM Countries 
                                            AS c WHERE c.Name = @countryName)";
                    command.ExecuteNonQuery();

                    //sqlTran.Commit();
                    Console.WriteLine($"{affectedTowns.Count} town names were affected.");
                    Console.WriteLine($"[{String.Join(", ",affectedTowns).ToUpper()}]");
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                    try
                    {
                        sqlTran.Rollback();
                    }
                    catch (Exception exRollBack)
                    {

                        Console.WriteLine(exRollBack.Message);

                    }
                }
               



                
            }

                
         
        }
    }
}
