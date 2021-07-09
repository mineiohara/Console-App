using System;

namespace GPA
{
    class Program
    {
        static void Main(string[] args)
        {
            const string SENIOR_STUDENT = "senior student";
            const string JUNIOR_STUDENT = "junior student";
            const int MY_GRADE = 2;
            const decimal MY_TARGET_GPA = 4.3m;
            const Boolean IS_SENIOR_STUDENT = MY_GRADE >= 2 ? true : false;

            Console.WriteLine("I am {0} at NTU, and my target GPA of this semester is {1}.", IS_SENIOR_STUDENT ? SENIOR_STUDENT : JUNIOR_STUDENT, MY_TARGET_GPA);
        }
    }
}
