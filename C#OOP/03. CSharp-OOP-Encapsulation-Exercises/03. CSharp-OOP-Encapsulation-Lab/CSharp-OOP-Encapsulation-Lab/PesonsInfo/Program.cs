using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonsInfo
{
  public   class StartUp
    {
        static void Main(string[] args)
        {

            int inputCount = int.Parse(Console.ReadLine());
            var persons = new List<Person>();

            for (int i = 0; i < inputCount; i++)
            {
                try
                {
                    var input = Console.ReadLine().Split();
                    persons.Add(new Person(input[0], input[1], int.Parse(input[2]), decimal.Parse(input[3])));
                }
                catch (Exception ex )
                {

                    Console.WriteLine(ex.Message);
                }
               

            }
            //var percentage = decimal.Parse(Console.ReadLine());

            //persons.OrderBy(p => p.FirstName)
            //    .ThenBy(p => p.Age)
            //    .ToList()
            //    .ForEach(Console.WriteLine);
            //persons.ForEach(p => p.IncreaseSalary(percentage));

            //persons.ForEach(Console.WriteLine);
                
                
            var team =new Team("softuni");

            foreach (var item in persons)
            {
                team.AddPlayer(item);
                
            }
            
            Console.WriteLine($"First team has {team.FirstTeam.Count()} players.");
            Console.WriteLine($"Reserve team has {team.ReserveTeam.Count()} players.");

        }
    }
}
