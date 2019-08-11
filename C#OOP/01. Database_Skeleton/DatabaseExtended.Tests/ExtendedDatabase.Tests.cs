


using NUnit.Framework;
using System;

namespace Tests
{
    public class ExtendedDatabaseTests
    {
        private ExtendedDatabase data;
        private Person[] persons;
        [SetUp]
        public void Setup()
        {
            var firstPerson = new Person(20, "Pesho");
            var secondPerson = new Person(21, "Gosho");
            persons = new Person[] { firstPerson, secondPerson };



             data = new ExtendedDatabase(persons);
        }

        [Test]
        public void Test_Database_Set_Correctly()
        {
            int expectedCount = 2;
            Assert.AreEqual(expectedCount, this.data.Count);
        }

        [Test]
        public void Test_Add_Set_Correctly()
        {
            int expectedCount = 3;
            this.data.Add(new Person(22, "Zoro"));
            Assert.AreEqual(expectedCount, this.data.Count);
        }

        [Test]
        public void Test_Add_IfThereAreAlreadyUsersWithThisUsername()
        {

            Assert.Throws<InvalidOperationException>(() => this.data.Add(new Person(28, "Pesho")));
        }

        [Test]
        public void Test_Add_IfThereAreAlreadyUsersWithThisID()
        {

            Assert.Throws<InvalidOperationException>(() => this.data.Add(new Person(20, "Stavri")));
        }

        [Test]
        public void Test_Add_ThrowExeptionIfCapacityIsDifferentThan16()
        {

            for (int i = 2; i < 16; i++)
            {
                this.data.Add(new Person(i,$"Rado{i}"));
            }

            Assert.Throws<InvalidOperationException>(() => this.data.Add(new Person(99, $"Rado{99}")));
        }

        [Test]
        public void Test_RemoveIsWorkingCorrectly()
        {
            int expectedCount = 1;
            this.data.Remove();
            Assert.AreEqual(expectedCount, this.data.Count);
            
        }

        [Test]
        public void Test_RemoveShoudThrowExceptionIfWeTryToRemovePersonFromEmptyCollection()
        {

            for (int i = this.data.Count - 1; i >= 0; i--)
            {
                this.data.Remove();
            }

            Assert.Throws<InvalidOperationException>(() => this.data.Remove());

        }

        [Test]
        public void Test_FindByUsernamer_ShoudThrowExeptionIfPersonNameIsNullOrEmpty()
        {

           

            Assert.Throws<ArgumentNullException>(() => this.data.FindByUsername(""));

        }


        [Test]
        public void Test_FindByUsernamer_ProperlyWorking()
        {

            var currentPerson = new Person(100, "Superman");

            this.data.Add(currentPerson);

            var result = this.data.FindByUsername("Superman");
            Assert.AreEqual(currentPerson, result);
            

        }

        [Test]
        public void Test_FindByUsernamer_ShoudThrowExeptionIfPersonNameDoesntExist()
        {



            Assert.Throws<InvalidOperationException>(() => this.data.FindByUsername("Hulk"));

        }



        [Test]
        public void Test_FindByID_ProperlyWorking()
        {

            var currentPerson = new Person(100, "Superman");

            this.data.Add(currentPerson);

            var result = this.data.FindById(100);
            Assert.AreEqual(currentPerson, result);


        }

        [Test]
        public void Test_FindById_ShoudThrowExeptionIfPersonIdDoesntExist()
        {



            Assert.Throws<InvalidOperationException>(() => this.data.FindById(999));

        }
        [Test]
        public void Test_FindById_ShoudThrowExeptionIfPersonIdIsNegativeNum()
        {



            Assert.Throws<ArgumentOutOfRangeException>(() => this.data.FindById(-1));

        }

        //[Test]
        //public void Test_AddRange_WorkingCorrectly()
        //{
        //    var personCollection = new ExtendedDatabase.Person[5];
        //    for (int i = 0; i < 5; i++)
        //    {
        //        var person = new ExtendedDatabase.Person(i, $"Pesho{i}");
        //        personCollection[i] = person;
        //    }
        //    this.data.
        //    int expectedCount = 7;

        //    Assert.AreEqual(expectedCount, this.data.Count);

        //}
    }
}