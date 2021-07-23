using System;

namespace BuffonNeedleSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            double ratio, approximatePI, y, theta, b, d1, d2, D, crossed, length, height;
            Random rand = new Random();

            Console.Write("Please enter the length of needle(less than 1): ");
            length = double.Parse(Console.ReadLine());
            Console.Write("Please enter the height of Page: ");
            height = double.Parse(Console.ReadLine());

            for (int nDrops = 100; nDrops <= 1000; nDrops += 50)//For each the number of droped needle.
            {
                crossed = 0;

                for (int i = 1; i <= nDrops; i++)//Generate Random needle and check each needle whether it cross line or not.
                {
                    y = -height + height * rand.NextDouble();
                    theta = Math.PI * rand.NextDouble();
                    b = Math.Floor(y);
                    d1 = Math.Abs(y - b);
                    d2 = Math.Abs(b + 1.0 - y);
                    D = Math.Min(d1, d2);
                    if (0.5 * length * Math.Sin(theta) >= D) crossed++;
                }

                ratio = crossed / nDrops;
                approximatePI = 2 * length / ratio;
                Console.WriteLine("nDrops = {0}, ratio = {1}, approximatePI = {2}", nDrops, ratio.ToString("F6"), approximatePI);
            }
        }
    }
}
