﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    public class Tire
    {
        private int year;
        private double pressure;

        public Tire(int year, double prsure)
        {
            this.Year = year;
            this.Pressure = prsure;
        }


        public int Year
        {
            get { return year; }
            set { year = value; }
        }


        public double Pressure
        {
            get { return pressure; }
            set { pressure = value; }
        }

    }
}