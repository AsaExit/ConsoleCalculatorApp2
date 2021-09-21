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
            double inputNumberOne = -5.1;
            double inputNumberTwo = -3.4;

            //Act
            double result = Calc.Addition(inputNumberOne, inputNumberTwo);

            //Assert
            Assert.Equal(-8.5, result);
        }

        [Theory]
        [InlineData(new double[4] { 1.1, -2.2, 5, 9 })]
        [InlineData(new double[5] { 1.1, -3.3, 5, 7, 8.8 })]
        public void Addition(double[] arr)
        {
            //Arrange
            double result;
            double resultTest = 0;

            //Act
            for (int i = 0; i < arr.Length; i++)
            {
                resultTest += arr[i];
            }
            result = Calc.Addition(arr);

            //Assert
            Assert.Equal(resultTest, result);
        }

        //SUB
        [Fact]
        public void SubtractionTestOne()
        {
            double inputNumberOne = 99;
            double inputNumberTwo = 45.5;

            double result = Calc.Subtraction(inputNumberOne, inputNumberTwo);
            Assert.Equal(53.5, result);
        }

    }
}
