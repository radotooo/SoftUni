using System;

namespace ggg
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            var family = new Family();


            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine().Split();
                var person = new Person(input[0], int.Parse(input[1]));
                family.AddMembers(person);


            }





            var result = family.GetOldesMember();
            Console.WriteLine($"{result.Name} {result.Age }");

        }
    }
}
