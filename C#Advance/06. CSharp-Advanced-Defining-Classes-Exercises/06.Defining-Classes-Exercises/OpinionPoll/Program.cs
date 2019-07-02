using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Opinion_Poll
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            var listOfPerson = new List<Person>();

            while (count>0)
            {
                string[] input = Console.ReadLine().Split();

                string personName = input[0];
                int personAge = int.Parse(input[1]);

                var person = new Person(personName, personAge);
                listOfPerson.Add(person);
                count--;
            }

            foreach (var person in listOfPerson.Where(x=>x.Age>30).OrderBy(x=>x.Name))
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }

        }
    }
}
