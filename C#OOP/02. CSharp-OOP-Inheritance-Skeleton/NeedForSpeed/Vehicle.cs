using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class Vehicle
    {
        public int HorsePower { get; set; }
        public double Fuel { get; set; }
        public virtual double FuelConsumption { get; set; }

        protected double DefaultFuelConsumption ;
        



        public Vehicle(int horsepower , double fuel)
        {
            this.HorsePower = horsepower;
            this.Fuel = fuel;
            this.DefaultFuelConsumption = 1.25;
        }

        public void Drive(double km)
        {
            this.Fuel -= DefaultFuelConsumption * km;
           
        }

    }
}
