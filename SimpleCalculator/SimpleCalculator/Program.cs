using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input formula:");
            string userInput = Console.ReadLine();
            double num1 = userInput[0] - '0';
            double num2 = userInput[2] - '0';
            char arithmetic = userInput[1];
            double result = 0;

            if (arithmetic == '+') result = num1 + num2;
            else if (arithmetic == '-') result = num1 - num2;
            else if (arithmetic == '*') result = num1 * num2;
            else if (arithmetic == '/') result = num1 / num2;

            Console.WriteLine(result);
        }
    }
}
