using System;
using System.Collections.Generic;
using System.Linq;

namespace Pokemon
{
    public class StartUp
    {
        static void Main(string[] args)
        {
           //Func<Trainers,bool> chekHealth = x => x.Pokemons.Where(x => x.Health>0) ;

            Dictionary<string, Trainers> trainersList = new Dictionary<string, Trainers>();

            while (true)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string trainerName = input[0];
                if (trainerName == "Tournament")
                {
                    break;
                }
                string pokemonName = input[1];
                string pokemonElement = input[2];
                int pokemonHealth = int.Parse(input[3]);

                if (!trainersList.ContainsKey(trainerName))
                {
                    var pokemon = new Pokemon(pokemonName, pokemonHealth, pokemonElement);

                    var trainer = new Trainers(trainerName);
                    trainer.Pokemons.Add(pokemon);
                    trainersList[trainerName] = trainer;
                }
                else
                {
                    var pokemon = new Pokemon(pokemonName, pokemonHealth, pokemonElement);
                    trainersList[trainerName].Pokemons.Add(pokemon);
                }
            }


            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }
                bool hasElement = false;


                chek(trainersList, input, hasElement);
                hasElement = false;

            }

            //var result = trainersList.SelectMany(x => x.Value.Pokemons.Where(c => c.health > 0));

           

            foreach (var item in trainersList.OrderByDescending(x=>x.Value.NumbersOfBadges))
            {
                int count = 0;
                foreach (var item2 in item.Value.Pokemons.Where(x=>x.Health>0))
                {
                    count++;
                }

                Console.WriteLine($"{item.Value.Name} {item.Value.NumbersOfBadges} {count}");
                //foreach (var item2 in item.Value.Pokemons)
                //{
                //    if(item2.Health <= 0)
                //    {
                        
                //    }
                //}
            }


        }

        private static void chek(Dictionary<string, Trainers> trainersList, string input, bool hasElement)
        {
            foreach (var names in trainersList)
            {
                string current = string.Empty;
                foreach (var item in names.Value.Pokemons)
                {
                    if (item.Element == input)
                    {
                        if (item.Health > 0)
                        {
                            hasElement = true;
                        }
                    }
                }
                if (hasElement)
                {
                    names.Value.NumbersOfBadges++;
                }
                else
                {
                    foreach (var item in names.Value.Pokemons)
                    {
                        //if (item.Health > 0)
                        //{
                            item.Health -= 10;
                        //}
                        //else
                        //{
                        //    current = item.Name;
                        //}
                    }
                    //names.Value.Pokemons.FindIndex()
                }
                hasElement = false;
            }
        }



    }
}

