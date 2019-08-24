using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Bus : Vehicle
    {
       

        public Bus(double fuelQuantity, double fuelConsimption, int tank) : base(fuelQuantity, fuelConsimption, tank)
        {

        }

        public override void Refuel(double fuel)
        {
            base.Refuel(fuel);

        }

        public string DriveEmpty(double km )
        {
            
            double currentFuel = this.FuelConsumption  * km;
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
    }
}
