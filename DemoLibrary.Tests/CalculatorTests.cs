using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DemoLibrary.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void Add_SimpleValuesShouldCalculate()
        {
            // Arrange 
            double expected = 5;

            // Actual
            double actual = Calculator.Add(3, 2);

            // Assert
            Assert.Equal(expected, actual);

        }


        [Theory]
        [InlineData(3,2,5)]
        [InlineData(5.4,4.5,9.9)]
        public void Add_SimpleValuesShouldCalculate2(double x, double y, double expected)
        {
            // Arrange 
            //double expected = 5;

            // Actual
            double actual = Calculator.Add(x, y);

            // Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(6,3,2)]
        [InlineData(5000,0,0)]
        public void Divide_TestCaseList(double x, double y, double expected)
        {
            // Arrange

            // Actual
            double actual = Calculator.Divide(x, y);

            // Assert 
            Assert.Equal(expected, actual);

        }




        //[Fact]
        //public void Add_ComplexValuesShouldCalculate()
        //{

        //    //Arrange
        //    double expected = 10.6;

        //    //Actual
        //    double actual = Calculator.Add(2.3, 8.3);

        //    //Assert
        //    Assert.Equal(expected, actual);

        //}





    }
}
