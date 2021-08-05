using System;

namespace RomanNumeralCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string result = "";
            string[,] romanTable = new string[,] { { "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" }, { "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" }, { "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" }, { "M", "MM", "MMM", "M_V", "_V", "_VM", "_VMM", "", "" } };
            string[] nums;

            if (input.Contains('+'))
            {
                nums = input.Split('+');
                result = ArabicToRoman(RomanToArabic(nums[0], romanTable) + RomanToArabic(nums[1], romanTable), romanTable);
            }
            else if (input.Contains('-'))
            {
                nums = input.Split('-');
                result = ArabicToRoman(RomanToArabic(nums[0], romanTable) - RomanToArabic(nums[1], romanTable), romanTable);
            }
            else if (input.Contains('*'))
            {
                nums = input.Split('*');
                result = ArabicToRoman(RomanToArabic(nums[0], romanTable) * RomanToArabic(nums[1], romanTable), romanTable);
            }
            else if (input.Contains('/'))
            {
                nums = input.Split('/');
                result = ArabicToRoman(RomanToArabic(nums[0], romanTable) / RomanToArabic(nums[1], romanTable), romanTable);
            }

            Console.WriteLine(result);
        }


        static int RomanToArabic(string input, string[,] table)
        {
            int checkedIndex = 0;
            int lastIndex = -1;
            string arabicNum = "0";
            try
            {
                Console.WriteLine("Convert input {0} to {1}", input, Convert.ToInt32(input));
                return Convert.ToInt32(input);
            }
            catch
            {
                while (input.Length > checkedIndex)
                {
                    for (int i = 3; i > -1; i--)
                    {
                        for (int j = 8; j > -1; j--)
                        {
                            if (table[i, j] == "") continue;
                            else if (input.IndexOf(table[i, j], checkedIndex) == checkedIndex)
                            {
                                if (lastIndex - 2 == i) arabicNum += "0";
                                else if (lastIndex - 3 == i) arabicNum += "00";
                                arabicNum += Convert.ToString(j + 1);
                                lastIndex = i;
                                checkedIndex += table[i, j].Length;
                            }
                        }
                    }
                }

                if (lastIndex > 0)
                {
                    for (int i = 0; i < lastIndex; i++)
                    {
                        arabicNum += "0";
                    }
                }

                Console.WriteLine("Convert input {0} to {1}", input, Convert.ToInt32(arabicNum));
                return Convert.ToInt32(arabicNum);
            }
        }

        static string ArabicToRoman(int num, string[,] table)
        {
            string result = "";
            if (num == 0) return result = "zero";
            if (num / 1000 != 0)
            {
                result = table[3, num / 1000 - 1];
                num -= (num / 1000) * 1000;
            }
            if (num / 100 != 0)
            {
                result += table[2, num / 100 - 1];
                num -= (num / 100) * 100;
            }
            if (num / 10 != 0)
            {
                result += table[1, num / 10 - 1];
                num -= (num / 10) * 10;
            }
            if (num != 0)
            {
                result += table[0, num - 1];
            }
            return result;
        }
    }
}