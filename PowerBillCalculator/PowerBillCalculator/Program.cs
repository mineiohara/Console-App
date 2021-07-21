using System;
using System.Collections.Generic;

namespace PowerBillCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int month;
            double power,sum = 0;
            List<double> cost;

            Console.Write("Input which month: ");
            month = int.Parse(Console.ReadLine());
            Console.Write("Input the power you spent: ");
            power = int.Parse(Console.ReadLine());

            if (month >= 6 & month <= 9) cost = new List<double> { 1.63, 2.38, 3.52, 4.8, 5.66, 6.41 };
            else cost = new List<double> { 1.63, 2.1, 2.89, 3.94, 4.6, 5.03 };

            if (power > 1000)
            {
                sum += (power - 1000) * cost[5];
                power = power - (power - 1000);
            }
            if (power > 700)
            {
                sum += (power - 700) * cost[4];
                power = power - (power - 700);
            }
            if (power > 500)
            {
                sum += (power - 500) * cost[3];
                power = power - (power - 500);
            }
            if (power > 330)
            {
                sum += (power - 330) * cost[2];
                power = power - (power - 330);
            }
            if (power > 120)
            {
                sum += (power - 120) * cost[1];
                power = power - (power - 120);
            }
            if (power > 0)
            {
                sum += power * cost[0];
            }

            Console.WriteLine("You should pay NT${0}.", Math.Ceiling(sum));
        }
    }
}
