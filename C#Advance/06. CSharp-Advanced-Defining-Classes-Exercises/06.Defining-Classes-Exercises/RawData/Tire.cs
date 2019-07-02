using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    public class Tire
    {
        public double[] TirePressure { get; set; }
        public int[] TireAge { get; set; }


        public Tire(double eho)
        {

        }
        public Tire(double tire1, int age1, double tire2, int age2,
            double tire3, int age3, double tire4,int age4)
        {
            TirePressure = new double[4] { tire1, tire2, tire3, tire4 };
            TireAge = new int[4] { age1, age2, age3, age4 };
        }
       
    }
}
