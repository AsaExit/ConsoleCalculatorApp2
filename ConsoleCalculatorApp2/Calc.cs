using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleCalculatorApp2
{
    class Calc
    {
     // States

        // Fields
        double inputNumberOne;
        double inputNumberTwo;
        double result;


        // Property

        // Behavior

        // Constructor

        // Methods

        // Addition method takes the double property and calculate and return the result 
        public double Addition(double inputNumberOne, double inputNumberTwo)
        {
            double result = inputNumberOne + inputNumberTwo;
            return result;
        }

        public double Addition(double[] arr)
        {
           double result = 0;
            for(int i=0;i < arr.Length; i++)
            {
                result += arr[i];
            }
            return result;
        }
        // Substraction method takes the double property and calculate and return the result  
        public double Subtraction(double inputNumberOne, double inputNumberTwo)
        {
            double result = inputNumberOne - inputNumberTwo;
            return result;
            
        }
        // Multiplication  method takes the double property and calculate and return the result 
         public double Multiplication(double inputNumberOne, double inputNumberTwo)
        {
            double result = inputNumberOne * inputNumberTwo;
            return result;
        }
        // Division method takes the double property and calculate and return the result 
        public double Division(double inputNumberOne, double inputNumberTwo)
        {
            double result = inputNumberOne / inputNumberTwo;
            if (inputNumberTwo == 0)
                Console.WriteLine("Can not divied with 0");
            else if (inputNumberTwo != 0)
                Console.WriteLine("Go");
            return result;
        }
    }
}
