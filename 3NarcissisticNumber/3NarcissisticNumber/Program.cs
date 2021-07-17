using System;

namespace _3NarcissisticNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentNumber = 100;

            while (currentNumber.ToString().Length < 4)
            {
                if (currentNumber == Math.Pow(currentNumber.ToString()[0] - '0', 3) + Math.Pow(currentNumber.ToString()[1] - '0', 3) + Math.Pow(currentNumber.ToString()[2] - '0', 3))
                {
                    Console.WriteLine("{0} is a 3-Narcissistic Number",currentNumber);
                }

                currentNumber++;
            }
        }
    }
}
