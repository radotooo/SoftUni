using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public abstract class Vehicle
    {
        public double FuelQuantity { get; protected set; }

        //private double fuelQuantity;

        //public double FuelQuantity
        //{
        //    get { return fuelQuantity; }
        //   protected set
        //    {
        //        if (value > TankCpacity)
        //        {
        //            this.fuelQuantity = 0;

        //        }
        //        else
        //        {
        //            fuelQuantity = value;
        //        }
        //    }
        //}



        public  double FuelConsumption { get; protected set; }
        public int TankCpacity { get; set; }



        public Vehicle(double fuelQuantity , double fuelConsimption,int tank)
        {
            if(fuelQuantity > tank)
            {
                this.FuelQuantity = 0;
            }
            else
            {
                this.FuelQuantity = fuelQuantity;

            }
            this.FuelConsumption = fuelConsimption;
            this.TankCpacity = tank;
            

        }

        public  string Drive(double km )
        {
            double num = 0;
            if(this.GetType().Name == "Car")
            {
                num = 0.9;
            }
            else if (this.GetType().Name == "Truck")
            {
                num = 1.6;
            }
            else if(this.GetType().Name == "Bus")
            {
                num = 1.4;
            }
            double currentFuel = (this.FuelConsumption + num) * km;
            if (this.FuelQuantity - currentFuel > 0)
            {
                this.FuelQuantity -= currentFuel;

                return $"{GetType().Name} travelled {km} km";
            }
            else
            {
                return $"{GetType().Name} needs refueling";
            }
        }


        public override string ToString()
        {

            return $"{this.GetType().Name}: {this.FuelQuantity:F2}";
        }


        public virtual void Refuel(double fuel)
        {
            if(fuel <= 0 )
            {
                throw new ArgumentException("Fuel must be a positive number");
            }
            if(this.FuelQuantity + fuel > TankCpacity)
            {
                throw new ArgumentException($"Cannot fit {fuel} fuel in the tank");
            }

            //if (this.GetType().Name == "Car")
            //{
            //    this.FuelQuantity += fuel;
            //}
            //else
            //{
            //    this.FuelQuantity += fuel * 0.95;
            //}
        }
        

    }
}
