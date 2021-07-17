using System;

namespace NumberTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int range;
            Console.WriteLine("Enter a range:");
            range = int.Parse(Console.ReadLine());

            for (int i = 1; i <= range; i++)
            {
                for (int j = i; j <= range; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= i; k++)
                {
                    Console.Write(k);
                }

                for (int l = i-1; l > 0; l--)
                {
                    Console.Write(l);
                }

                Console.Write("\n");
            }
        }
    }
}
