using System;

namespace Calculator
{
    public static class Program
    {
        public static void Main()
        {
            Console.WriteLine("Please enter your first number: ");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your second number: ");
            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("What would you like to do?: add, subtract, multiply, or divide");
            string math = (Console.ReadLine());

            int result = 0;
            
            if (math == "add")
            {
                result = firstNumber + secondNumber;
            }
            if (math == "subtract")
            {
                result = firstNumber - secondNumber;
            }
            if (math == "multiply")
            {
                result = firstNumber * secondNumber;
            }
            if (math == "divide")
            {
                result = firstNumber / secondNumber;   
            }

            Console.WriteLine(result);

            Console.ReadLine();
            
        }
    }
}
