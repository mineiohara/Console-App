using System;

namespace SayHello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, " + name + "!");

        }
    }
}
