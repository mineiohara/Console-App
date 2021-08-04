using System;

namespace RomanArbicNumeralConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputNum = Console.ReadLine();
            bool Arabic = CheckRomanOrArbic(inputNum);
            string[,] romanTable = new string[,] { { "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" }, { "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" }, { "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" }, { "M", "MM", "MMM", "M_V", "_V", "_VM", "_VMM", "", "" } };

            if (Arabic) ArabicToRoman(inputNum,romanTable);
            else RomanToArabic(inputNum, romanTable);
        }

        static bool CheckRomanOrArbic(string input)//True -> Arabic, False -> Roman
        {
            bool result;
            try
            {
                int.Parse(input);
                result = true;
            }
            catch
            {
                result = false;
            }

            return result;
        }

        static void RomanToArabic(string input, string[,] table)
        {
            int checkedIndex = 0;
            int lastIndex = -1;
            while (input.Length > checkedIndex + 1)
            {
                for(int i = 3; i > -1; i--)
                {
                    for(int j = 8; j > -1; j--)
                    {
                        if (table[i, j] == "") continue;
                        else if (input.IndexOf(table[i, j],checkedIndex)  == checkedIndex)
                        {
                            if (lastIndex - 2 == i) Console.Write("0");
                            else if (lastIndex - 3 == i) Console.Write("00");
                            Console.Write(j + 1);
                            lastIndex = i;
                            checkedIndex += table[i, j].Length;
                        }
                    }
                }
            }

            if (lastIndex > 0)
            {
                for(int i = 0; i < lastIndex; i++)
                {
                    Console.Write("0");
                }
            }


        }

        static void ArabicToRoman(string input, string[,] table)
        {
            int num = int.Parse(input);

            if (num/1000 != 0)
            {
                Console.Write(table[3, num / 1000 - 1]);
                num -= (num / 1000) * 1000;
            }
            if (num/100 != 0)
            {
                Console.Write(table[2, num / 100 - 1]);
                num -= (num / 100) * 100;
            }
            if (num / 10 != 0)
            {
                Console.Write(table[1, num / 10 - 1]);
                num -= (num / 10) * 10;
            }
            if (num != 0)
            {
                Console.Write(table[0, num - 1]);
             }
        }
    }
}
