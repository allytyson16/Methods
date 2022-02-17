using System;

namespace Ref_Keyword
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentGrade = 75;
            GiveExtraCredit(ref studentGrade);
            Console.WriteLine(studentGrade);
        }
        public static void GiveExtraCredit(ref int studentGrade)
        {
            studentGrade += 3;

        }
    }
}
