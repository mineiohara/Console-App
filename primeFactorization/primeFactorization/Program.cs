using System;
using System.Collections.Generic;

namespace primeFactorization
{
    class Program
    {
        static void Main(string[] args)
        {
            int targetNum, currentNum = 1;
            List<int> factor = new List<int>();

            Console.Write("Enter a positive integer: ");
            targetNum = int.Parse(Console.ReadLine());

            while (currentNum != targetNum)
            {
                for (int i = 2; i <= targetNum/currentNum; i++)
                {
                    if ((targetNum / currentNum )% i == 0)
                    {
                        currentNum *= i;
                        factor.Add(i);
                        break;
                    }
                }
            }

            Console.Write("{0}={1}", targetNum, factor[0]);
            if (factor.Count > 0)
            {
                for (int i = 1; i < factor.Count; i++)
                {
                    Console.Write("*{0}", factor[i]);
                }
            }
        }
    }
}
