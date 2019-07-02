using System;
using System.Collections.Generic;
using System.Text;

namespace SpeedRacing
{
    public class Car
    {
        private string _model;
        private double _fuelAmount;
        private double _fuelConsumptionPerKilometer;
        private double _travelledDistance;

        public Car(string model , double fuelAmount, double fuelConsumptionFor1km)
        {
            this.Model = model;
            this._fuelAmount = fuelAmount;
            this._fuelConsumptionPerKilometer = fuelConsumptionFor1km;

        }

        public string Model
        {
            get { return this._model; }
            set { this._model = value; }
        }

        public double FuelAmount
        {
            get { return this._fuelAmount; }
            set { this._fuelAmount = value; }
        }

        public double FuelConsumptionPerKilometer
        {
            get { return this._fuelConsumptionPerKilometer; }
            set { this._fuelConsumptionPerKilometer = value; }
        }

        public double TravelledDistance
        {
            get { return this._travelledDistance; }
            set { this._travelledDistance = value; }
        }

        public void Drive (double amountOfKm)
        {
            double fuelNeedet = amountOfKm * FuelConsumptionPerKilometer;

            if(fuelNeedet <= _fuelAmount)
            {
                _travelledDistance += amountOfKm;
                _fuelAmount -= fuelNeedet;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }

        }

        public override string ToString()
        {
            return $"{_model} {_fuelAmount:F2} {_travelledDistance}";
        }

    }
}
