using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    class Tire
    {
        private int year;
        private int pressure;

        public Tire(int year, double presure)
        {
            this.Year = year;
            this.Pressure = pressure;
        }


        public int Year
        {
            get { return year; }
            set { year = value; }
        }


        public int Pressure
        {
            get { return pressure; }
            set { pressure = value; }
        }

    }
}
