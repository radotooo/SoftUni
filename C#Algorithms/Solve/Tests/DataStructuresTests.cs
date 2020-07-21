using DataStructures;
using System;
using Xunit;

namespace Tests
{
    public class DataStructuresTests

    {
        [Fact]
        public void SumAndAverage()
        {
            Assert.Equal("Sum=15; Average=5.00", Solve.SumAndAverage(new int[] { 4,5,6}));
            Assert.Equal("Sum=2; Average=1.00", Solve.SumAndAverage(new int[] { 1,1}));
            Assert.Equal("Sum=0; Average=0.00", Solve.SumAndAverage(new int[] { }));
            Assert.Equal("Sum=10; Average=10.00", Solve.SumAndAverage(new int[] { 10}));
            Assert.Equal("Sum=5; Average=1.67", Solve.SumAndAverage(new int[] { 2,2,1}));
        }



    }
}
