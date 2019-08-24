using System;

namespace Animals
{
   public class StartUp
    {
        static void Main(string[] args)
        {
           Animal cat = new Cat("zoro", "koshudka");
            var dog = new Dog("Pesho", "Kifte");

            Console.WriteLine(cat.ExplainSelf());
            Console.WriteLine(dog.ExplainSelf());


        }
    }
}
