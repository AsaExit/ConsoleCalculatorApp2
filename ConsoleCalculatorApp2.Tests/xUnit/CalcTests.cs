using System;
using Xunit;


namespace ConsoleCalculatorApp2.Tests
{
    public class CalcTests
    {
        [Fact]
        public void AdditionTestGood()
        {
            //Arrange
            double inputNumberOne = 99;
            double inputNumberTwo = 0;

            //Act
            double result = Calc.Addition(inputNumberOne, inputNumberTwo);

            //Assert
            Assert.Equal(99, result);
        }

        [Fact]
        public void AdditionTestGoodDecimal()
        {
            //Arrange
            double inputNumberOne = 1.3;
            double inputNumberTwo = 3.4;

            //Act
            double result = Calc.Addition(inputNumberOne, inputNumberTwo);

            //Assert
            Assert.Equal(4.7, result);
        }

        [Fact]
        public void AdditionTestGoodNegativNumbers()
        {
            //Arrange
            double inputNumberOne = -1.3;
            double inputNumberTwo = 3.4;

            //Act
            double result = Calc.Addition(inputNumberOne, inputNumberTwo);

            //Assert
            Assert.Equal(3, result);
        }
    }
}
