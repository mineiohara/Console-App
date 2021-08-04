using System;

namespace RomanArbicNumeralConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputNum = Console.ReadLine();
            bool Arabic = CheckRomanOrArbic(inputNum);

            if (Arabic) ArabicToRoman(inputNum);
            else RomanToArabic(inputNum);
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

        static int RomanToArabic(string input)
        {

        }

        static string ArabicToRoman(int input)
        {

        }
    }
}
