namespace Person
{
    using System;
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

         
                var child = new Child(name, age);
                Console.WriteLine(child);
           
            
           
            
            
            
            //var childName = System.Console.ReadLine();
            //var childAge = int.Parse(System.Console.ReadLine());
            //var child = new Child(childName, childAge);
            //System.Console.WriteLine($"Name: {child.Name}, Age: {child.Age}");
        }
    }
}