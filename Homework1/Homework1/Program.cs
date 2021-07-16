using System;
using System.Collections;
using System.Collections.Generic;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            double height, weight, BMI;
            int selectedMenu;
            List<double> recordedBMI = new List<double>();
            List<string> recordedName = new List<string>();

            while (true)
            {
                Console.WriteLine("=====BMI Calculator Menu=====\nPlease enter the number of menu.\n1:Calculate your BMI.\n2:Review recorded BMI.\n3:Exit Calculator.");
                selectedMenu = int.Parse(Console.ReadLine());

                switch (selectedMenu)
                {
                    case 1://Calculate BMI
                        Console.WriteLine("\nPlease enter your name:");//enter name
                        name = Console.ReadLine();

                        Console.WriteLine("\nPlease enter your height(m):");//enter height
                        height = double.Parse(Console.ReadLine());

                        Console.WriteLine("\nPlease enther your weight(kg):");//enter weight
                        weight = double.Parse(Console.ReadLine());

                        BMI = Math.Round(weight / (height * height), 1, MidpointRounding.AwayFromZero);//calculate BMI and take first decial places
                        Console.WriteLine("\nYour BMI is {0}.", BMI);
                        if (BMI < 18.5) Console.WriteLine("It's Underweight.\n");
                        else if (BMI < 25) Console.WriteLine("It's Normal Range.\n");
                        else Console.WriteLine("It's Obese.\n");
                        
                        recordedBMI.Add(BMI);//add the BMI to list of name
                        recordedName.Add(name);//add the name to list of name

                        break;

                    case 2://Review recorded BMI
                        if (recordedBMI.Count == 0) Console.WriteLine("\nNo data!\n");

                        else
                        {
                            Console.WriteLine("\nName             BMI");
                            for(int i = 0; i < recordedBMI.Count; i++)//print all of record
                            {
                                Console.WriteLine("{0}          {1}", recordedName[i], recordedBMI[i]);
                            }
                            Console.WriteLine("\n");
                        }
                        break;

                    case 3://System break
                        return;

                    default://Selecting Error
                        Console.WriteLine("\nNothing the number of menu like that.\n");
                        break;
                }
            }
        }
    }
}
