using System;

namespace PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int height, sum=0;

            Console.Write("Please input height of the Pascal's triangle: ");
            height = int.Parse(Console.ReadLine());

            for(int i = 0; i < height; i++)
            {
                sum += (int)Math.Pow(2, i);
            }

            Console.Write(sum);
        }
    }
}
