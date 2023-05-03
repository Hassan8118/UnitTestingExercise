using System;
using Xunit;
using Xunit.Sdk;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)]          //Add test data <-------
        [InlineData(6, 7, 2, 15)]
        [InlineData(7, 8, 3, 18)]
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            var Calc = new Calculator();

            //Act
                // call the Add method that is located in the Calculator class
                // and store its result in a variable named actual
            var actual = Calc.Add(num1, num2, num3);

            //Assert
                //Assert.Equal(expected, actual);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(7, 6, 1)]//Add test data <-------
        [InlineData(5, 6, -1)]
        [InlineData(4, 1, 3)]
        [InlineData(4, 5, -1)]
        public void SubtractTest(int minuend, int subtrahend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var Calc = new Calculator();

            //Act
            var actual = Calc.Subtract(minuend, subtrahend);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(4, 5, 20)]//Add test data <-------
        [InlineData(6, 2, 12)]
        [InlineData(8, 9, 72)]
        [InlineData(9, 6, 54)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var Calc = new Calculator();

            //Act
            var actual = Calc.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(42, 6, 7)]//Add test data <-------
        [InlineData(16, 8, 2)]
        [InlineData(144, 12, 12)]
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var Calc = new Calculator();

            //Act
            var actual = Calc.Divide(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
