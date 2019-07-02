using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
//    {cargoWeight
//} {cargoType} 
    public class Cargo
    {
        public string CargoType { get; set; }
        public int CargoWeight { get; set; }

        public Cargo(string cargoType , int weight)
        {
            CargoType = cargoType;
            CargoWeight = weight;
        }
    }
}
