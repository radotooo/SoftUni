﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    public class Car
    {
        //        •	make: string
        //•	model: string
        //•	year: int
        //The class should also have public properties for:
        //•	Make: string
        //•	Model: string
        //•	Year: int




        private string make;
        private string model;
        private int year;
        private double fuelQuantity;
        private double fuelConsumption;


        public Car()
        {
            this.Make = "VW";
            this.Model = "Golf";
            this.Year = 2025;
            this.FuelQuantity = 200;

            this.FuelConsumption = 10;
        }

        public Car(string make, string model, int year)
            : this()
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption)
          : this(make, model, year)

        {
            this.FuelQuantity = fuelQuantity;

            this.FuelConsumption = fuelConsumption;

        }

        public string Make
        {
            get
            {
                return this.make;
            }
            set
            {
                this.make = value;
            }
        }
        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                this.model = value;
            }
        }
        public int Year
        {
            get
            {
                return this.year;
            }
            set
            {
                this.year = value;
            }
        }


        public double FuelQuantity
        {
            get { return this.fuelQuantity; }
            set { fuelQuantity = value; }
        }


        public double FuelConsumption
        {
            get
            {
                return this.fuelConsumption;
            }
            set
            {
                this.fuelConsumption = value;
            }
        }

        public void Drive(double distance)
        {
            var result = (this.fuelQuantity - distance) * this.fuelConsumption;
            if (result > 0)
            {
                this.FuelQuantity -= result;
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");

            }
        }

        public string WhoAmI()
        {
            return $"Make: { this.Make}\nModel: { this.Model}\nYear: { this.Year}\nFuel: { this.FuelQuantity:F2}L";
        }



    }
}

