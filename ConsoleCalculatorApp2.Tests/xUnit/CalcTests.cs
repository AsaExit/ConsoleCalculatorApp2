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
            //ARRANGE
            double inputNumberOne = 99;
            double inputNumberTwo = 0;

            //ACT
            double result = Calc.Addition(inputNumberOne, inputNumberTwo);

            //ASSERT
            Assert.Equal(99, result);
        }

        [Fact]
        public void AdditionTestGoodDecimal()
        {
            //ARRANGE
            double inputNumberOne = 1.3;
            double inputNumberTwo = 3.4;

            //ACT
            double result = Calc.Addition(inputNumberOne, inputNumberTwo);

            //ASSERT
            Assert.Equal(4.7, result);
        }

        [Fact]
        public void AdditionTesBeginDecimal()
        {
            //ARRANGE
            double inputNumberOne = -1.3;
            double inputNumberTwo = 3.4;

            //ACT
            double result = Calc.Addition(inputNumberOne, inputNumberTwo);

            //ASSERT
            Assert.Equal(2.1, result, 2);
        }
        [Fact]
        public void AdditionTestGoodNegativNumbers()
        {
            //ARRANGE
            double inputNumberOne = -5.1;
            double inputNumberTwo = -3.4;

            //ACT
            double result = Calc.Addition(inputNumberOne, inputNumberTwo);

            //ASSERT
            Assert.Equal(-8.5, result);
        }

        [Theory]
        [InlineData(new double[4] { 1.1, -2.2, 5, 9 })]
        [InlineData(new double[5] { 1.1, -3.3, 5, 7, 8.8 })]
        public void AdditionArr(double[] arr)
        {
            //ARRANGE
            double result;
            double resultTest = 0;

            //ACT
            for (int i = 0; i < arr.Length; i++)
            {
                resultTest += arr[i];
            }
            result = Calc.Addition(arr);

            //ASSERT
            Assert.Equal(resultTest, result);
        }

        // ************** Subtraction Test **********************/
        [Fact]
        public void SubtractionTestOne()
        {
            //ARRANGE
            double inputNumberOne = 99;
            double inputNumberTwo = 45.5;

            //ACT
            double result = Calc.Subtraction(inputNumberOne, inputNumberTwo);

            //ASSERT
            Assert.Equal(53.5, result);
        }

        [Theory]
        [InlineData(new double[4] { 1.1, -2.2, 5, 9 })]
        [InlineData(new double[5] { 1.1, -3.3, 5, 7, 8.8 })]

        public void SubtractionTestArr(double[] arr)
        {
            //ARRANGE
            double result;
            double resultTest = arr[0];

            //ACT
            for (int i = 1; i < arr.Length; i++)
            {
                resultTest -= arr[i];
            }
            result = Calc.Subtraction(arr);

            //ASSERT
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
            //ARRANGE
            double inputNumberOne = 8;
            double inputNumberTwo = 5.5;

            //ACT

            double result = Calc.Multiplication(inputNumberOne, inputNumberTwo);

            //ASSERT
            Assert.Equal(44, result);
        }

        // ************** Division Test **********************/

        [Fact]
        public void DivisionTest()
        {
            //ARRANGE
            double inputNumberOne = 99;
            double inputNumberTwo = 1.1;
            //ACT
            double result = Calc.Division(inputNumberOne, inputNumberTwo);
            //ASSERT
            Assert.Equal(90, result, 2);
        }
        [Fact]
        public void DivisionWithThePrecision()
        {
            double inputNumberOne = 1;
            double inputNumberTwo = 3;
            //ACT
            double result = Calc.Division(inputNumberOne, inputNumberTwo);
            //ASSERT
            Assert.Equal(0.33, result, 2);
        }

        [Fact]
        public void DivisionIsZeroTest()
        {
            //ARRANGE

            double inputNumberOne = 99;
            double inputNumberTwo = 0;

            //ACT
            DivideByZeroException result = Assert.Throws<DivideByZeroException>(
                 () => Calc.Division(inputNumberOne, inputNumberTwo));

            //ASSERT
            Assert.Equal("Divisor cannot be 0!", result.Message);
        }
    }
}
