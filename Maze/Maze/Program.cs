using System;
using static System.Console;
using System.Threading.Tasks;

namespace Maze
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            char[,] map = new char[10, 10];
            int[] player = new int[2] {1,0};

            Display(player);

            while (true)
            {
                input = Console.ReadKey().Key.ToString();

                if (input == "RightArrow" && map[player[0],player[1]+1] != '■') player[1]++; 
                if (input == "LeftArrow" && map[player[0], player[1] - 1] != '■') player[1]--;
                if (input == "UpArrow" && map[player[0] - 1, player[1]] != '■') player[0]--;
                if (input == "DownArrow" && map[player[0] + 1, player[1]] != '■') player[0]++;

                map = Display(player);
                if (player[0] == 8 && player[1] == 9)
                {
                    WriteLine();
                    Write("Clear!!");
                    break;
                }
            }

        }

        static char[,] Display(int[] player)
        {
            Clear();
            char[,] map = new char[10,10]{
                { '■','■','■','■','■','■','■','■','■','■'},
                { '　','　','　','■','　','　','　','■','　','■'},
                { '■','　','　','■','　','■','　','■','　','■'},
                { '■','　','■','■','■','■','　','　','　','■'},
                { '■','　','　','　','　','■','　','■','　','■'},
                { '■','■','■','■','　','■','　','■','　','■'},
                { '■','　','　','　','　','■','　','■','　','■'},
                { '■','　','■','■','■','■','　','■','　','■'},
                { '■','　','　','　','　','　','　','■','　','★'},
                { '■','■','■','■','■','■','■','■','■','■'}
            };

            map[player[0], player[1]] = '◇';

            WriteLine("Arrow Key to move(↑,↓,→,←)");
            WriteLine();
            for (int j = 0; j < map.GetLength(0); j++)
            {
                for (int i = 0; i < map.GetLength(1); i++)
                {
                    Write(map[j, i]);
                }
                WriteLine();
            }
            return map;
        }
    }
}
