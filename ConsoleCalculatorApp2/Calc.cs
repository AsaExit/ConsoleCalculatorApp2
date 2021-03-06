using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleCalculatorApp2
{
    public class Calc
    {
     // States // Fields // Property // Behavior // Constructor

        // Methods

        // Addition method takes the double property and calculate and return the result 
        public static double Addition(double inputNumberOne, double inputNumberTwo)
        {
            double result = inputNumberOne + inputNumberTwo;
            return result;
        }

        public static double Addition(double[] arr)
        {//{ 1.1, -3.3, 5, 7, 8.8 }
            double result = 0;
            for(int i=0;i < arr.Length; i++)
            {
                result += arr[i];
            }
            return result;
        }
        // Substraction method takes the double property and calculate and return the result  
        public static double Subtraction(double inputNumberOne, double inputNumberTwo)
        {
            double result = inputNumberOne - inputNumberTwo;
            return result;
            
        }

        public static double Subtraction(double[] arr)
        {//{ 1.1, -3.3, 5, 7, 8.8 }
            try 
            { double darthResult = arr[0]; 
            }
            catch (IndexOutOfRangeException)
            
            { return 0; 
            }
            double result = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                result -=  arr[i];
            }
            return result;

            /*double result = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                result += arr[i];
            }
            return result;*/

        }
        // Multiplication  method takes the double property and calculate and return the result 
        public static double Multiplication(double inputNumberOne, double inputNumberTwo)
        {
            double result = inputNumberOne * inputNumberTwo;
            return result;
        }
        // Division method takes the double property and calculate and return the result 
        public static double Division(double inputNumberOne, double inputNumberTwo)
        {
            if (inputNumberTwo == 0)
            {
                throw new DivideByZeroException("Divisor cannot be 0!");
            }

            return inputNumberOne / inputNumberTwo;

        }

    }// End of Calc class
}// End of Class namespace
