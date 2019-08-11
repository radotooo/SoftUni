using NUnit.Framework;
using System;

namespace Tests
{
    public class DatabaseTests
    {

        private Database database;

        [SetUp]
        public void Setup()
        {
            this.database = new Database(1, 2);
        }

        [Test]
        public void Test_IfConstructorWorkCorrectly()
        {
            int expectedCount = 2;


            Assert.AreEqual(expectedCount, this.database.Count);

        }

        [Test]
        public void Test_Add_Correctly()
        {

            this.database.Add(1);
            int expectedCount = 3;
            Assert.AreEqual(expectedCount, this.database.Count, "Doesnt Add Correctly");
        }

        [Test]
        public void Test_Add_ThrowExeptionIfCapacityIsDifferentThan16()
        {

            for (int i = 2; i < 16; i++)
            {
                this.database.Add(i);
            }
            
            Assert.Throws<InvalidOperationException>(()=>this.database.Add(1));
        }
        [Test]
        public void Test_Remove_Correctly()
        {
            int expectedCount = 1;
            this.database.Remove();
            Assert.AreEqual(expectedCount, this.database.Count);
           
        }
        [Test]
        public void Test_Remove_ThrowExeptionIfTryToRemoveOnEmptyCollection()
        {
            for (int i = this.database.Count - 1; i >= 0; i--)
            {
                this.database.Remove();
            }


            Assert.Throws<InvalidOperationException>(() => this.database.Remove());
        }
        [Test]
        public void Test_Fletch_Results()
        {
            int[] expectedResult = new int[] { 1, 2 };

            var result = this.database.Fetch();
            Assert.That(expectedResult, Is.EqualTo(result));

        }

    }
}