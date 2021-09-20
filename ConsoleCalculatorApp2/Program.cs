using System;

namespace ConsoleCalculatorApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Calc calculator = new Calc();
            bool keepLooping = true;

            while (keepLooping)
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.WriteLine("-----------Calculator---------------");
                Console.WriteLine("Enter the seletion you whant Todo\n");

                Console.WriteLine(" Press 1 for Addision"
                                + "\n Press 2 for Substraction"
                                + "\n Press 3 for Multiplication"
                                + "\n Press 4 for Division\n");
                //+ "\n Press 9 for Exit the calculater\n");


                double selector = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter 1st Number");
                double inputNumberOne = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter 2nd Number");
                double inputNumberTwo = Convert.ToInt32(Console.ReadLine());
                double result = 0;



                switch (selector)
                {
                    case 1:
                        {
                            result = Addition(inputNumberOne, inputNumberTwo);
                            break;
                        }
                    case 2:
                        {
                            result = Subtraction(inputNumberOne, inputNumberTwo);
                            break;
                        }
                    case 3:
                        {
                            result = Multiplication(inputNumberOne, inputNumberTwo);
                            break;
                        }
                    case 4:
                        {
                            result = Division(inputNumberOne, inputNumberTwo);
                            //while(inputNumberTwo == 0)
                            //Console.WriteLine("Canot divied with 0");

                            break;
                        }
                    case 9:
                        keepLooping = false;
                        Console.WriteLine("Thanks for youring this program.");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Wrong action!! try again");
                        break;
                }
                Console.WriteLine("The result is {0}", result);
                PressToContinue();
            }
            //Addition method takes thedouble property and calculate and return the result 
             static double Addition(double inputNumberOne, double inputNumberTwo)
            {
                double result = inputNumberOne + inputNumberTwo;
                return result;
            }
            //Substraction method takes thedouble property and calculate and return the result  
             static double Subtraction(double inputNumberOne, double inputNumberTwo)
            {
                double result = inputNumberOne - inputNumberTwo;
                return result;
            }
            //Multiplication  method takes thedouble property and calculate and return the result 
             static double Multiplication(double inputNumberOne, double inputNumberTwo)
            {
                double result = inputNumberOne * inputNumberTwo;
                return result;
            }
            //Division method takes thedouble property and calculate and return the result 
             static double Division(double inputNumberOne, double inputNumberTwo)
            {
                double result = 0;
                if (inputNumberTwo == 0)
                    throw new DivideByZeroException("Divisor cannot be 0!");
                else
                {  result = inputNumberOne / inputNumberTwo; }

                return result;

            }
        
            // A method for go back to for the Calculater start (Menu)
            static void PressToContinue()
            {
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey(true);
            }

        }// End of Main

    }// End of Program Class
}// End of namespace
