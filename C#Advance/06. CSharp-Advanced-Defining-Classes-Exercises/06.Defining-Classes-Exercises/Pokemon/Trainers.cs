using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon
{
    public class Trainers
    {
        private string name;
        private int numbersOfBadges;
        private List<Pokemon> pokemons;


        public Trainers()
        {
            numbersOfBadges = 0;
        }

        public Trainers(string name)
            :this()
        {
            Name = name;
            
            pokemons = new List<Pokemon>();
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        public int NumbersOfBadges
        {
            get { return numbersOfBadges; }
            set { numbersOfBadges = value; }
        }


        public List<Pokemon> Pokemons
        { 
            get { return pokemons; }
            set { pokemons = value; }
        }



    }
}
