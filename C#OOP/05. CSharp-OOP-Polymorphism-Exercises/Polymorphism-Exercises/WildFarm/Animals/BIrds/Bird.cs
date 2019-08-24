﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Animals.BIrds
{
    public abstract class Bird : Animal
    {
        

        public double  WingSize { get; protected set; }

        public Bird(string name, double weight, double wingSise) : base(name, weight)
        {
            this.WingSize = wingSise;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, {this.WingSize}, {this.Weight}, {this.FoodEaten}]";
        }

    }
}
