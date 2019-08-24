using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Truck : Vehicle
    {
        

        public Truck(double fuelQuantity, double fuelConsimption, int tank) : base(fuelQuantity, fuelConsimption, tank)
        {
        }

        //chek here if erroe appear !
        public override void Refuel(double fuel)
        {
            base.Refuel(fuel);
            this.FuelQuantity += fuel * 0.95;
        }
    }
}
