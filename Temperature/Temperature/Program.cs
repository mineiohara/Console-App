using System;

namespace Tempreture
{
    class program
    {
        static int Main(string[] args)
        {
            Boolean isEnd = false;
            Console.Write("temperature of Celsius:");
            try
            {
                double degreesCelsius;
                degreesCelsius = double.Parse(Console.ReadLine());
                double degreesFahrenheit = 9 / 5 * degreesCelsius + 32;
                if (degreesFahrenheit < -459.67)
                {
                    throw new ArgumentException();
                }

                if (degreesFahrenheit > 82.4)
                {
                    Console.Write("It's hot!");
                }
                else if (degreesFahrenheit > 59.00)
                {
                    Console.Write("It's warm!"); ;
                }
                else if (degreesFahrenheit > 50.00)
                {
                    Console.Write("It's cool!"); ; ; ; ; ; ; ; ; ;
                }
                else if (degreesFahrenheit > 41.00)
                {
                    Console.Write("It's chilly!");
                }
                else if (degreesFahrenheit > 32.00)
                {
                    Console.Write("It's cold!"); ; ; ;
                }
                else
                {
                    Console.Write("It's freezing!");
                }
                isEnd = true;
            }
            catch (Exception e) { }
            Console.Write(isEnd ? "\nEnd" : "Something wrong, please check.");
            return isEnd ? 0 : -1;
        }
    }
}