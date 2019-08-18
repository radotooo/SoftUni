using System;
using System.Collections.Generic;
using System.Linq;

namespace BorderControl
{
    public class StartUp
    {
        public static string name;
        public static string id;
        public static int age;
        public static string model;
        public static string birthday;


        static void Main(string[] args)
        {
            var visitorsList = new List<IInterface>();
            var humanoids = new List<IBuyer>();


            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                string[] input = Console.ReadLine().Split();
                if (input.Length == 4)
                {
                    if (humanoids.Any(x => x.Name == input[0]))
                    {
                        continue;
                    }
                    name = input[0];
                    age = int.Parse(input[1]);
                    id = input[2];
                    birthday = input[3];

                    var citizen = new Citizen(name, age, id, birthday);
                    humanoids.Add(citizen);


                }
                else
                {
                    if (humanoids.Any(x => x.Name == input[0]))
                    {
                        continue;
                    }
                    name = input[0];
                    age = int.Parse(input[1]);
                    string group  = input[2];
                    var rebel = new Rebel(name, age, group);
                    humanoids.Add(rebel);
                }


            }
            string command;
            while ((command = Console.ReadLine())!="End")
            {
                if(humanoids.Any(x=>x.Name==command))
                {
                    var current = humanoids.FirstOrDefault(x => x.Name == command);
                    current.BuyFood();
                }
            }
            int result = 0;

            foreach (var item in humanoids)
            {
                result += item.Food;
            }
            Console.WriteLine(result);
        }



        //            while (true)
        //            {
        //                string[] input = Console.ReadLine().Split();
        //                if(input[0]=="End")
        //                {
        //                    break;
        //                }

        //                switch (input[0])
        //                {
        //                    case "Citizen":
        //                         name = input[1];
        //                         age = int.Parse(input[2]);
        //        id = input[3];
        //                        birthday = input[4];

        //                        var citizen = new Citizen(name, age, id, birthday);
        //        visitorsList.Add(citizen);
        //                        break;
        //                    case "Robot":
        //                         model = input[1];
        //                         id = input[2];
        //                        var robot = new Robot(model, id);
        //        visitorsList.Add(robot);
        //                        break;
        //                    case "Pet" :
        //                        name = input[1];
        //                        birthday = input[2];
        //                        var pet = new Pet(name, birthday);
        //        visitorsList.Add(pet);

        //                        break;
        //                    default:
        //                        break;
        //                }



        //}

        //string chek = Console.ReadLine();

        //            foreach (var visitor in visitorsList)
        //            {
        //                if(visitor.Birthday.EndsWith(chek))
        //                {
        //                    Console.WriteLine(visitor.Birthday);

        //                }
        //}


    }

}

