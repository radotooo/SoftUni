using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    //Write a program that tracks cars and their cargo. 
    //Define a class Car that holds an information about model,
    //    engine, cargo and a collection of exactly 4 tires.
    //    The engine, cargo and tire should be separate classes.
    //    Create a constructor that receives all of the information about
    //        the Car and creates and initializes its inner components 
    //        (engine, cargo and tires).

    public class Car
    {
        public Cargo Cargo { get; set; }
        public Engine Engine { get; set; }
        public Tire Tire { get; set; }
        //public Tire TirePressure { get; set; }

        public string Model { get; set; }

        

    }
}
