using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Car : Vehicle
    {
      

        public Car(double fuelQuantity, double fuelConsimption, int tank) : base(fuelQuantity, fuelConsimption, tank)
        {
        }

        public override void Refuel(double fuel)
        {
            base.Refuel(fuel);

            this.FuelQuantity += fuel;

        }
        //public override string Drive(double km)
        //{
        //    double currentFuel = (this.FuelConsumption + 0.9) * km;
        //    if(this.FuelQuantity - currentFuel > 0)
        //    {
        //        this.FuelQuantity -= currentFuel;

        //        return $"Car travelled {km} km";
        //    }
        //    else
        //    {
        //        return $"Car needs refueling";
        //    }

        //}

        //public override void Refuel(double fuel)
        //{
        //    this.FuelQuantity += fuel;
        //}
    }
}
