using System;

namespace CatchTheFlyBall
{
    class Program
    {
        static void Main(string[] args)
        {
            double v, gravity = 0.1, v0 = new Random().NextDouble() * 4.5 + 0.5;
            int xPlayer, xBall, y, NX, NY, time = 0;

            Console.WriteLine("Please Input NX:");
            NX = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Input NY:");
            NY = int.Parse(Console.ReadLine()) + 1;
            Console.WriteLine("Please Input player vevlocity V:");
            v = double.Parse(Console.ReadLine());
            char[,] screen = new char[NX, NY];

            for(int i = 0; i < NY; i++)
            {
                for (int j = 0; j < NX; j++)
                {
                    screen[j, i] = ' ';
                }
            }

            while (true)
            {
                xBall = getHorizontalDistance(v0, time);
                xPlayer = getHorizontalDistance(v, time);
                y = getVerticalDistance(gravity, time);

                if (y >= NY-1 || xBall >= NX || xPlayer >= NX)
                {
                    if (catchBall(xBall, xPlayer)) Console.WriteLine("Catch the Ball!");
                    else Console.WriteLine("Cannot Catch the Ball!");
                    break;
                }

                updateScreen('o', xBall, y, NX, NY, screen);
                updateScreen('I', xPlayer, NY-1, NX, NY, screen);
                time++;
            }
        }

        static void updateScreen(char symbol, int x, int y, int NX, int NY, char[,] screen)
        {
            screen[x, y] = symbol;
            Console.Clear();

            for (int i = 0; i < NY; i++)
            {
                for  (int j = 0; j < NX; j++)
                {
                    Console.Write(screen[j, i]);
                }
                Console.WriteLine();
            }
        }

        static int getHorizontalDistance(double v0, int time)
        {
            double x = v0 * time;
            return (int)x;
        }

        static int getVerticalDistance(double gravity, int time)
        {
            double y = 0.5 * gravity * time * time;
            return (int)y;
        }

        static bool catchBall(int xBall, int xPlayer)
        {
            return (xPlayer >= xBall);
        }
    }
}
