using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleCalculatorApp2
{
    class Calc
    {
     // States

        // Fields
        int inputNumberOne;
        int inputNumberTwo;
        int result;


        // Property

        // Behavior

        // Constructor

        // Methods

        // Addition method takes the int property and calculate and return the result 
        public int Addition(int inputNumberOne, int inputNumberTwo)
        {
            int result = inputNumberOne + inputNumberTwo;
            return result;
        }
        // Substraction method takes the int property and calculate and return the result  
         public int Subtraction(int inputNumberOne, int inputNumberTwo)
        {
            int result = inputNumberOne - inputNumberTwo;
            return result;
        }
        // Multiplication  method takes the int property and calculate and return the result 
         public int Multiplication(int inputNumberOne, int inputNumberTwo)
        {
            int result = inputNumberOne * inputNumberTwo;
            return result;
        }
        // Division method takes the int property and calculate and return the result 
        public int Division(int inputNumberOne, int inputNumberTwo)
        {
            int result = inputNumberOne / inputNumberTwo;
            if (inputNumberTwo == 0)
                Console.WriteLine("Can not divied with 0");
            else if (inputNumberTwo != 0)
                Console.WriteLine("Go");
            return result;
        }
    }
}
