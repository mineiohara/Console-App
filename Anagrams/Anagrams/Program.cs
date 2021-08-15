using System;

namespace Anagrams
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] checkedIndex;
            bool anagrams = true;

            Console.Write("Enter first word:");
            char[] firstWord = Console.ReadLine().ToCharArray();
            Console.Write("Enter second word:");
            char[] secondWord = Console.ReadLine().ToCharArray();

            Array.Sort(firstWord);
            Array.Sort(secondWord);

            
            for (int i = 0; i < firstWord.Length; i++)
            {
                if (firstWord[i] != secondWord[i])
                {
                    Console.Write("The words are not anagrams.");
                    return;
                }
            }
            
            Console.Write("The words are anagrams.");
        }
    }
}
