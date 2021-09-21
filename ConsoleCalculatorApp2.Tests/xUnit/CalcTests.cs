using System;
using Xunit;


namespace ConsoleCalculatorApp2.Tests
{
    public class CalcTests
    {
        // ************** Addition Test **********************/
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
        public void AdditionArr(double[] arr)
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

        // ************** Subtraction Test **********************/
        [Fact]
        public void SubtractionTestOne()
        {
            double inputNumberOne = 99;
            double inputNumberTwo = 45.5;

            double result = Calc.Subtraction(inputNumberOne, inputNumberTwo);
            Assert.Equal(53.5, result);
        }
        [Theory]
        [InlineData(new double[4] { 1.1, -2.2, 5, 9 })]
        [InlineData(new double[5] { 1.1, -3.3, 5, 7, 8.8 })]

        public void SubtractionTestArr(double[] arr)
        {
            //Arrange
            double result;
            double resultTest = arr[0];

            //Act
            for (int i = 1; i < arr.Length; i++)
            {
                resultTest -= arr[i];
            }
            result = Calc.Subtraction(arr);

            //Assert
            Assert.Equal(resultTest, result);
        }
        [Fact]
        public void SubtractionOverLord()
        {
            //ARRANGE
            double expected = -60.6;
            double[] arr = new double[4]
            {-2.2, 5.5, -8.2, 61.1};



            //ACT
            double actual = Calc.Subtraction(arr);

            //ASSERT
            Assert.Equal(expected, actual);
        }


        // ************** Multiplication Tests**********************/

        [Fact]
        public void MultiplicationTest()
        {
            double inputNumberOne = 8;
            double inputNumberTwo = 5.5;

            double result = Calc.Multiplication(inputNumberOne, inputNumberTwo);

            Assert.Equal(44, result);
        }

        // ************** Division Test **********************/

        [Fact]
        public void DivisionTest()
        {
            double inputNumberOne = 99;
            double inputNumberTwo = 1.1;

            double result = Calc.Division(inputNumberOne, inputNumberTwo);
            Assert.Equal(90, result, 2);
        }
        [Fact]
        public void DivisionWithThePrecision()
        {
            double inputNumberOne = 1;
            double inputNumberTwo = 3;

            double result = Calc.Division(inputNumberOne, inputNumberTwo);

            Assert.Equal(0.33, result, 2);
        }

        [Fact]
        public void DivisionIsZeroTest()
        {
            //Arange

            double inputNumberOne = 99;
            double inputNumberTwo = 0;


            //Act
            DivideByZeroException result = Assert.Throws<DivideByZeroException>(
                 () => Calc.Division(inputNumberOne, inputNumberTwo));

            //Assert
            Assert.Equal("Divisor cannot be 0!", result.Message);
        }
    }
}
