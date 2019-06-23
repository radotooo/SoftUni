using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Filter_by_Agr
{
    public class People
    {
        public string Name { get; set; }
        public int Age { get; set; }

    }


    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            var person = new List<People>();

            for (int i = 0; i < num; i++)
            {
                string[] entry = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                var people = new People
                {
                    Name = entry[0],
                    Age = int.Parse(entry[1])
                };
                person.Add(people);
            }

            string condition = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            Func<People, bool> cheker;

            if (condition == "older")
            {
                cheker = x => x.Age >= age;
            }
            else
            {
                cheker = x => x.Age < age;
            }

            string format = Console.ReadLine();

            Func<People, string> selectPrint;

            if (format == "name age")
            {
                selectPrint = x => $"{x.Name} - {x.Age}";
            }
            else if (format == "age")
            {
                selectPrint = x => $"{x.Age}";

            }
            else 
            {
                selectPrint = x => $"{x.Name}";

            }

            person
                .Where(cheker)
                .Select(selectPrint)
                .ToList()
                .ForEach(Console.WriteLine);


           

        }
    }
}
