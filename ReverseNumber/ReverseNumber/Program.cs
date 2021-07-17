using System;
using System.Collections.Generic;

namespace ReverseNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string num,reversedNum;
            List<char> result = new List<char>();

            while (true)
            {
                Console.Write("Enter a number: ");
                num = Console.ReadLine();

                if (int.Parse(num) < 0) break;

                Console.Write("Reversed number: ");
                for (int i = num.Length-1; i > -1; i--)
                {
                    result.Add(num[i]);
                    Console.Write(num[i]);
                }

                Console.WriteLine("\n");
            }

            Console.Write("A sequence of reversed number: ");
            for (int j = 0; j < result.Count; j++)
            {
                Console.Write(result[j]);
            }
        }
    }
}
