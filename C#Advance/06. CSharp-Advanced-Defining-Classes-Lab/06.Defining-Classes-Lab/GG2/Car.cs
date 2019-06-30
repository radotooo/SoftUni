using CarManufacturer;
using System;
using System.Collections.Generic;
using System.Text;



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
    private Engine engine;
    private Tire[] tire;


   

    public Engine Engine
    {
        get { return engine; }
        set { engine = value; }
    }
    

    public Tire[] Tire
    {
        get { return tire; }
        set { tire = value; }
    }


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

    public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption,Engine engine,Tire[] tire )
        : this(make, model, year,fuelQuantity,fuelConsumption)
    {
        this.Engine = engine;
        this.Tire = tire;
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
        var result = this.fuelQuantity - ( distance * (this.fuelConsumption/100));
        if (result > 0)
        {
            this.FuelQuantity -= distance*(this.fuelConsumption/100);
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

