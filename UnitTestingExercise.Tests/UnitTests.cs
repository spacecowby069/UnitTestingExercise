using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(1,2,3,6)]
        [InlineData(5,5,5,15)]
        public void Add(int num1, int num2, int num3, int expected)
        {
            //Arrange
            UnitTestMethods tester = new UnitTestMethods();
            
            //Act
            int actual = tester.Add(num1, num2, num3);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5,5,0)]
        [InlineData(5, 10, -5)]
        public void Subtract(int minuend, int subtrahend, int expected)
        {
            //Arrange
            UnitTestMethods tester = new UnitTestMethods();

            //Act
            var actual = tester.Subtract(minuend, subtrahend);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2, 2, 4)]
        [InlineData(5, 4, 20)]
        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange
            UnitTestMethods tester = new UnitTestMethods();

            //Act
            var actual = tester.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(16, 4, 4)]
        [InlineData(25, 5, 5)]
        [InlineData(30, 5, 6)]
        public void Divide(int num1, int num2, int expected)
        {
            //Arrange
            UnitTestMethods tester = new UnitTestMethods();

            //Act
            var actual = tester.Divide(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void IsCharSymbol()
        {
            //Arrange
            UnitTestMethods tester = new UnitTestMethods();
            string symbols = "$~^+<>|";

            foreach (char character in symbols)
            {
                //Act
                bool isSymbolActual = tester.IsCharSymbol(character);
                //Assert
                Assert.True(isSymbolActual);
            }
            
        }

        [Fact]
        public void IsCharNotSymbol()
        {
            

            //Arrange
            UnitTestMethods tester = new UnitTestMethods();
            string lettersAndNums = "0123456789abcdefghijklmnopqrstuvwxyz";

            foreach (char character in lettersAndNums)
            {
                //Act
                bool isLetterNumActual = tester.IsCharNotSymbol(character);
                //Assert
                Assert.True(isLetterNumActual);
            }

        }
    }
}
