using System;
using System.Collections.Generic;

namespace Animals

{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Engine engine = new Engine();
            engine.Run();
            //string input;

            //List<Animal> animalList = new List<Animal>();

            //while ((input = Console.ReadLine()) != "Beast!")
            //{
            //    string[] commands = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
            //    string name = commands[0];

            //    int age = int.Parse(commands[1]);
            //    string gender = commands[2];

            //    try
            //    {
            //        switch (input)
            //        {
            //            case "Cat":
            //                animalList.Add(new Cat(name, age, gender));
            //                break;
            //            case "Frog":
            //                animalList.Add(new Frog(name, age, gender));
            //                break;
            //            case "Dog":
            //                animalList.Add(new Dog(name, age, gender));
            //                break;
            //            case "Kitten":
            //                animalList.Add(new Kitten(name, age));
            //                break;
            //            case "Tomcat":
            //                animalList.Add(new Tomcat(name, age));
            //                break;
            //            default:
            //                break;
            //        }

            //    }
            //    catch (Exception ex )
            //    {

            //        Console.WriteLine(ex.Message);

            //    }

            //}
            //animalList.ForEach(Console.WriteLine);

        }
    }
}
