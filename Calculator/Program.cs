using System;

namespace Calculator
{
    public static class Program
    {
        public static void Main()
        {



            Console.WriteLine("Please enter your first number: ");
            float firstNumber = float.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your second number: ");
            float secondNumber = float.Parse(Console.ReadLine());

            Console.WriteLine("What would you like to do?: +, -, *, or /");
            string math = (Console.ReadLine());

            float result = 0;

            if (math == "+")
            {
                result = firstNumber + secondNumber;
            }
            if (math == "-")
            {
                result = firstNumber - secondNumber;
            }
            if (math == "*")
            {
                result = firstNumber * secondNumber;
            }
            if (math == "/")
            {
                result = firstNumber / secondNumber;
            }

            Console.WriteLine($"The answer for your calculation is {result}");
            Console.ReadLine();
            
        

            
            //Console.WriteLine($"Total = {result}");


            
            //char[] operators = new char[4];
            

            //converting string to number


            // Create a simple calculator that asks the user to input two different numbers 
            // and whether they want to add, subtract, multiply or divide them. 


            //Console.ReadLine();
        }
    }
}
