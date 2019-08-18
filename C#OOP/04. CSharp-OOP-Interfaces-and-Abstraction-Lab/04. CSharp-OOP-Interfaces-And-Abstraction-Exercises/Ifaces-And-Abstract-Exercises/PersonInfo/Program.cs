using System;

namespace PersonInfo
{
   public class StartUp
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string id = Console.ReadLine();
            string birth = Console.ReadLine();
            var person = new Citizen(name, age);

            var idd = new Citizen(name, age, id, birth);
            Console.WriteLine(person.Name);
            Console.WriteLine(person.Age);
        }
    }
}
