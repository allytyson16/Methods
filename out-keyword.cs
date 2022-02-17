using System;

namespace out_keyword
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    int studentGrade = 75;
        //    GiveExtraCredit(out studentGrade);
        //    Console.WriteLine(studentGrade);
        //}
        //public static void GiveExtraCredit(out int studentGrade)
        //{
        //    studentGrade = 1;
        //    studentGrade += 3;
        //}

        static void Main(string[] args)
        {
            int add;
            int multiply;
            AddandMultiply(5, 10, out add, out multiply);
            Console.WriteLine(add);
            Console.WriteLine(multiply);

        }
        public static void AddandMultiply(int a, int b, out int add, out int multiply)
        {
            add = a + b;
            multiply = a * b;
        }

    }
}

