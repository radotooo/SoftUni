using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingSpree
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            string[] persons = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
            string[] shopings = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);


            List<Person> personList = new List<Person>();
            List<Product> productList = new List<Product>();

            try
            {
                FillList(personList, persons);

                FillList(productList, shopings);

            }
            catch (Exception ex )
            {

                Console.WriteLine(ex.Message);
                return;
                
            }

            while (true)
            {
                string[] input = Console.ReadLine().Split();
                if (input[0] == "END")
                {
                    break;
                }
                string personName = input[0];
                string prodcutName = input[1];

                var currentPerson = personList.FirstOrDefault(x => x.Name == personName);
                Console.WriteLine(currentPerson.ChekIfCanBought(productList.FirstOrDefault(x => x.Name == prodcutName)));

                //foreach (var person in personList)
                //{
                //    if (person.Name == personName)
                //    {
                //        var curreentProduct = productList.FirstOrDefault(x => x.Name == prodcutName);
                //        Console.WriteLine(person.ChekIfCanBought(curreentProduct));
                //    }
                //}

            }
            
            foreach (var item in personList)
            {
                if (item.BagOfProducts.Count == 0)
                {
                    Console.WriteLine($"{item.Name} - Nothing bought");
                    continue;
                }

                Console.WriteLine($"{item.Name} - {string.Join(", ", item.BagOfProducts.Select(x=>x.Name).ToList())}");


                
            }
        }


               



           
                

        private static void FillList(List<Product> productList, string[] shopings)
        {
            for (int i = 0; i < shopings.Length; i++)
            {
                var currentProduct = shopings[i].Split('=', StringSplitOptions.RemoveEmptyEntries);
                var product = new Product(currentProduct[0], decimal.Parse(currentProduct[1]));
                productList.Add(product);
            }
        }

        private static void FillList(List<Person> personList, string[] persons)
        {
            for (int i = 0; i < persons.Length; i++)
            {
                var currentPerson = persons[i].Split('=', StringSplitOptions.RemoveEmptyEntries);
                var person = new Person(currentPerson[0], decimal.Parse(currentPerson[1]));
                personList.Add(person);
            }
        }
    }
}

