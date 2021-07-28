using System;
using System.Collections.Generic;

namespace DrinkBarMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter base:");
            string[] bases = Console.ReadLine().Split(' ');
            Console.WriteLine("Enter fruit:");
            string[] fruits = Console.ReadLine().Split(' ');

            Console.WriteLine("Menu:");
            for(int i = 0; i < bases.Length; i++)
            {
                for(int j = 0; j < fruits.Length; j++)
                {
                    Console.Write(fruits[j] + bases[i] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
