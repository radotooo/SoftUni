using System;
using System.Collections.Generic;
using WildFarm.Animals;
using WildFarm.Animals.BIrds;
using WildFarm.Animals.Mammal;
using WildFarm.Animals.Mammal.Feline;


namespace WildFarm
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var animalList = new List<Animal>();

            while (true)
            {
                string[] input = Console.ReadLine().Split();
                if (input[0] == "End")
                {
                    break;
                }

                string animal = input[0];
                Food food;
                switch (animal)
                {
                    case nameof(Tiger):
                        var tiger = new Tiger(input[1], double.Parse(input[2]), input[3], input[4]);
                        Console.WriteLine(tiger.ProduceSound());
                             
                       food = FoodFactory.Create(Console.ReadLine().Split());

                        try
                        {
                            tiger.Eat(food);

                        }
                        catch (Exception ex )
                        {

                            Console.WriteLine(ex.Message);
                        }
                        animalList.Add(tiger);
                        break;
                    case "Cat":
                        var cat = new Cat(input[1], double.Parse(input[2]), input[3], input[4]);
                        Console.WriteLine(cat.ProduceSound());
                         food = FoodFactory.Create(Console.ReadLine().Split());

                        try
                        {
                            cat.Eat(food);

                        }
                        catch (Exception ex)
                        {

                            Console.WriteLine(ex.Message);
                        }
                        animalList.Add(cat);

                        break;
                    case "Dog":
                        var dog = new Dog(input[1], double.Parse(input[2]), input[3]);
                        Console.WriteLine(dog.ProduceSound());
                         food = FoodFactory.Create(Console.ReadLine().Split());


                        try
                        {
                            dog.Eat(food);

                        }
                        catch (Exception ex)
                        {

                            Console.WriteLine(ex.Message);
                        }
                        animalList.Add(dog);

                        break;
                    case "Mouse":
                        var mice = new Mouse(input[1], double.Parse(input[2]), input[3]);
                        Console.WriteLine(mice.ProduceSound());
                        food = FoodFactory.Create(Console.ReadLine().Split());


                        try
                        {
                            mice.Eat(food);

                        }
                        catch (Exception ex)
                        {

                            Console.WriteLine(ex.Message);
                        }
                        animalList.Add(mice);

                        break;
                    case "Hen":
                        var hen = new Hen(input[1], double.Parse(input[2]), double.Parse(input[3]));
                        Console.WriteLine(hen.ProduceSound());
                        food = FoodFactory.Create(Console.ReadLine().Split());

                        try
                        {
                            hen.Eat(food);

                        }
                        catch (Exception ex)
                        {

                            Console.WriteLine(ex.Message);
                        }
                        animalList.Add(hen);

                        break;
                    case "Owl":
                        var owl = new Owl(input[1], double.Parse(input[2]), double.Parse(input[3]));
                        Console.WriteLine(owl.ProduceSound());
                        food = FoodFactory.Create(Console.ReadLine().Split());

                        try
                        {
                            owl.Eat(food);

                        }
                        catch (Exception ex)
                        {

                            Console.WriteLine(ex.Message);
                        }
                        animalList.Add(owl);

                        break;
                    default:
                        break;
                }
            }
            animalList.ForEach(Console.WriteLine);

            //var hen = new Hen("GOGo", 2.5, 30);
            //Console.WriteLine(hen);
        }
       
    }
}

