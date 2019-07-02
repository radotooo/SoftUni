using System;
using System.Collections.Generic;
using System.Text;

namespace CarSalesman
{
    public class Engine
    {

        public string Model { get; set; }
        public int Power { get; set; }
        public int Displacement { get; set; }
        public string Efficiency { get; set; }

        //public Engine()
        //{
        //    Model = null;
        //    Power = 0;
        //    Displacement = 0;
        //    Efficiency = "n/a";
        //}
        public Engine(string model, int power, int displace)
            
        {
            Model = model;
            Power = power;
            Displacement = displace;
            Efficiency = "n/a";

        }

        public Engine(string model , int power , int displace , string effici)
            :this(model,power,displace)
        {
            Model = model;
            Power = power;
            Displacement = displace;
            Efficiency = effici;

        }

    }
}
