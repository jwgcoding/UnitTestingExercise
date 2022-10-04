using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            var c = new Calculator();
            
            //Act
                // call the Add method that is located in the Calculator class
                // and store its result in a variable named actual
                var actual = c.Add(num1, num2, num3);
            //Assert
                //Assert.Equal(expected, actual);
                Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2,1,1)]//Add test data <-------
        [InlineData(3,1,2)]
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var c = new Calculator();
            //Act
            var actual = c.Sub(minuend, subtrhend);
            //Assert
            Assert.Equal(expected,actual);
        }

        [Theory]
        [InlineData(6,3,18)]
        [InlineData(6,2,12)]//Add test data <-------
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var c = new Calculator();
            //Act
            var actual = c.Mutli(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(3,3,1)]
        [InlineData(4,2,2)]//Add test data <-------
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var c = new Calculator();
            //Act
            var actual = c.Divide(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
