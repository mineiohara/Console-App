using System;

namespace Minesweeper
{
    class Program
    {
        static void Main(string[] args)
        {
            const int XMAX = 9;
            const int YMAX = 9;
            const int nMine = 10;
            bool[,] isOpened = new bool[XMAX+2, YMAX+2];
            bool[,] isMine = new bool[XMAX+2, YMAX+2];
            int[,] neighborMine = new int[XMAX+2, YMAX+2];


            string input;
            int x, y;

            initializeMap(nMine, isOpened, isMine, neighborMine, XMAX, YMAX);
            dispayMap(isOpened, isMine, neighborMine, XMAX, YMAX);

            while (true)
            {
                input = Console.ReadLine();
                if (input == "1")
                {
                    initializeMap(nMine, isOpened, isMine, neighborMine, XMAX, YMAX);
                    dispayMap(isOpened, isMine, neighborMine, XMAX, YMAX);
                    continue;
                }
                else if (input == "2") break;
                else
                {
                    if (input[0] >= 'A' && input[0] <= 'I') x = input[0] - 'A' + 1;
                    else
                    {
                        dispayMap(isOpened, isMine, neighborMine, XMAX, YMAX);
                        continue;
                    }

                    if (input[1] >= '1' && input[1] <= '9') y = int.Parse(input[1].ToString());
                    else
                    {
                        dispayMap(isOpened, isMine, neighborMine, XMAX, YMAX);
                        continue;
                    }

                    openCell(x, y, XMAX, YMAX, isOpened, isMine, neighborMine);
                    dispayMap(isOpened, isMine, neighborMine, XMAX, YMAX);
                    if (isSuccess(XMAX, YMAX, isOpened, isMine)) Console.WriteLine("SUCCESS!!");
                    if (isMine[x,y]) Console.WriteLine("FAIL.");
                }
            }
            
        }

        static void initializeMap(int nMine, bool[,] isOpened, bool[,] isMine, int[,] neighborMine, int x, int y)
        {
            int i, j;

            for(i = 0; i < x+2; i++)
            {
                for(j = 0; j < y+2; j++)
                {
                    isOpened[i, j] = false;
                    isMine[i, j] = false;
                    neighborMine[i, j] = 0;
                }
            }

            for (int k = 0; k < nMine; k++)
            {
                do
                {
                    i = (int)(new Random().Next() % x + 1);     
                    j = (int)(new Random().Next() % y + 1);      
                } while (isMine[i,j]);

                isMine[i, j] = true;

                neighborMine[i - 1,j - 1] += 1;
                neighborMine[i,j - 1] += 1;
                neighborMine[i + 1,j - 1] += 1;
                neighborMine[i - 1,j] += 1;
                neighborMine[i + 1,j] += 1;
                neighborMine[i - 1,j + 1] += 1;
                neighborMine[i,j + 1] += 1;
                neighborMine[i + 1,j + 1] += 1;
            }
        }

        static void dispayMap(bool[,] isOpened, bool[,] isMine, int[,] neighborMine, int x, int y)
        {
            Console.Clear();
            Console.WriteLine("===============Minesweeper===============\nWhere would you like to open?(ex:A6)");
            Console.Write("\n\n        A B C D E F G H I\n");

            for (int j = 1; j <= y; j++)
            {
                Console.Write("      ");
                Console.Write(j);
                Console.Write(" ");

                for (int i = 1; i <= x; i++)
                {
                    if (!isOpened[i,j]) Console.Write("■");
                    else if (isMine[i,j]) Console.Write("*");
                    else if (neighborMine[i,j] == 0) Console.Write( "・");
                    else Console.Write(neighborMine[i,j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n\nOther options:\n1.reset\n2.exit\n=========================================");
        }

        static void openCell(int x, int y, int XMAX, int YMAX, bool[,] isOpened, bool[,] isMine, int[,] neighborMine)
        {
            if (x < 1 || x > XMAX || y < 1 || y > YMAX) return;
            if (isOpened[x, y]) return;

            isOpened[x, y] = true;
            if (!isMine[x, y] && neighborMine[x, y] == 0)
            {
                openCell(x - 1, y - 1, XMAX, YMAX, isOpened, isMine, neighborMine);
                openCell(x, y - 1, XMAX, YMAX, isOpened, isMine, neighborMine);
                openCell(x + 1, y - 1, XMAX, YMAX, isOpened, isMine, neighborMine);
                openCell(x - 1, y, XMAX, YMAX, isOpened, isMine, neighborMine);
                openCell(x + 1, y, XMAX, YMAX, isOpened, isMine, neighborMine);
                openCell(x - 1, y + 1, XMAX, YMAX, isOpened, isMine, neighborMine);
                openCell(x, y + 1, XMAX, YMAX, isOpened, isMine, neighborMine);
                openCell(x + 1, y + 1, XMAX, YMAX, isOpened, isMine, neighborMine);
            }
        }

        static bool isSuccess(int XMAX, int YMAX, bool[,] isOpend, bool[,] isMine)
        {
            for (int x = 1; x <= XMAX; ++x)
            {
                for (int y = 1; y <= YMAX; ++y)
                {
                    if (!isMine[x,y] && !isOpend[x,y])
                        return false;
                }
            }
            return true;
        }
    }
}
