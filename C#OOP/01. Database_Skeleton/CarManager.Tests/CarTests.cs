
using NUnit.Framework;
using System;

namespace Tests
{
    public class CarTests
    {
        private Car Car;

        [SetUp]
        public void Setup()
        {

            Car = new Car("Rado", "Golf", 10, 10);
        }

        [Test]
        public void Test_Car_Constructor()
        {
            Assert.IsNotNull(Car);
        }

        // >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> TEST Make <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

        [Test]
        public void Test_Make_Value()
        {
            var result = "Rado";
            Assert.AreEqual(result, Car.Make);

        }

        [Test]
        public void Test_Make_SetterCannotBeNullOrEmpty()
        {

            Assert.Throws<ArgumentException>(() => new Car("", "rado", 10, 10));
        }


        // >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> TEST Model <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        [Test]
        public void Test_Model_Value()
        {
            var result = "Golf";
            Assert.AreEqual(result, Car.Model);

        }

        [Test]
        public void Test_Model_SetterCannotBeNullOrEmpty()
        {

            Assert.Throws<ArgumentException>(() => new Car("gg", "", 10, 10));
        }

        // >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> TEST FuelConsumption <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

        [Test]
        public void Test_FuelConsumption_Value()
        {
            var result = 10;
            Assert.AreEqual(result, Car.FuelConsumption);

        }

        [Test]
        [TestCase(0)]
        [TestCase(-1)]
        public void Test_FuelConsumption_CannotBeZeroOrNegative(double num)
        {

            Assert.Throws<ArgumentException>(() => new Car("gg", "gg", num, 10));
        }

        // >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> TEST FuelCapacity <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

        [Test]
        public void Test_FuelCapacity_Value()
        {
            var result = 10;
            Assert.AreEqual(result, Car.FuelConsumption);

        }

        [Test]
        [TestCase(0)]
        [TestCase(-1)]
        public void Test_FuelCapacity_CannotBeZeroOrNegative(double num)
        {

            Assert.Throws<ArgumentException>(() => new Car("gg", "gg", 10, num));
        }


        // >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> TEST Refuel <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

        [Test]
        [TestCase(0)]
        [TestCase(-1)]
        public void Test_Refuel_FuelToRefillCannotBeZeroOrNegativeNum(double refuel)
        {
            Assert.Throws<ArgumentException>(() => Car.Refuel(refuel));
        }

        
        [Test]
        public void Test_Refuel_AddFuelToFuelAmountCorrectly()
        {
            double fuelAmount = 5;
            double result = 5;
            Car.Refuel(fuelAmount);
            Assert.AreEqual(result, Car.FuelAmount);
        }

        [Test]
        public void Test_Refuel_SetCorrectFuelAmount()
        {
            double fuelAmount = 15;
            double result = Car.FuelCapacity;
            Car.Refuel(fuelAmount);
            Assert.AreEqual(result, Car.FuelAmount);
        }

        // >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> TEST Drive <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        [Test]
        public void Test_Drive_ShoudThrowExeptionIfDontHaveEnoughtFuelForDistance()
        {

            Assert.Throws<InvalidOperationException>(() => Car.Drive(1000));

        }

        [Test]
        public void Test_Drive_ShoudReduceFuelAmount()
        {
            
            double distance = 5;
            Car.Refuel(10);
            double fuelNeeded = (distance / 100) * 10;
            double result = 10 - fuelNeeded;
            Car.Drive(distance);
            Assert.AreEqual(result, Car.FuelAmount);

           

        }

    }
}