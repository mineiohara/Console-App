using System;

namespace GCDAndLCM
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, temp1, temp2, remainder = 1;

            Console.WriteLine("Please enter num1:");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter num2:");
            num2 = int.Parse(Console.ReadLine());

            if (num1 < 1 || num2 < 1)
            {
                Console.WriteLine("Value out of range.");
                return;
            }
            else if (num1 >= num2)
            {
                temp1 = num1;
                temp2 = num2;
            }
            else
            {
                temp1 = num2;
                temp2 = num1;
            }
            
            while (remainder != 0)
            {
                remainder = temp1 % temp2;
                temp1 = temp2;
                temp2 = remainder;
            }

            Console.WriteLine("The Greatest Common Divisor of {0} and {1} is {2}\nThe Least Common Multiple is of {0} and {1} is {3}", num1, num2, temp1, num1*num2/temp1);
        }
    }
}
