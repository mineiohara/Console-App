using System;

namespace ProjectileMotion
{
    class Program
    {
        static void Main(string[] args)
        {
            const double g = 0.1;
            int NX, NY, x = 0, y = 0, time = 0;
            double v0;

            Console.WriteLine("Please Input NX:");
            NX = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Input NY:");
            NY = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Input V0:");
            v0 = double.Parse(Console.ReadLine());

            char[,] screen = new char[NX, NY];

            for (int i = 0; i < NY; i++)
            {
                for (int j = 0; j < NX; j++)
                {
                    screen[j, i] = ' ';
                }
            }

            while (true){
                //screen[x, y] = ' ';
                x = getHorizontalDistance(v0, time);
                y = getVerticalDistance(g, time);

                if (x >= NX || y >= NY)
                {
                    Console.WriteLine("Reach ground at {0}'s", time);
                    break;
                }
                updateScreen(x, y, NX, NY, screen);

                time += 1;
            }
        }

        static void updateScreen(int x, int y, int NX, int NY, char[,] screen)
        {
            screen[x, y] = 'o';
            Console.Clear();

            for (int i = 0; i < NY; i++)
            {
                for (int j = 0; j < NX; j++)
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

        static int getVerticalDistance(double g, int time)
        {
            double y = 0.5 * g * time * time;
            return (int)y;
        }

    }
}
