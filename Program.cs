using System;

namespace passby_reference_value
{
    class Program
    {
 //Pass by Reference and Pass by Value

        static void Main(string[] args)
        {
            //pass by value
            int student1Grade = 75;
            Console.WriteLine("Students grade before extra credit is {0}", student1Grade);
            GiveExtraCredit(student1Grade);


            //pass by reference
            int[] grades = new int[1];
            grades[0] = 85;
            Console.WriteLine("Students array grade before extra credit is {0}", grades[0]);
            GiveExtraCreditArray(grades);

        }
        public static void GiveExtraCredit(int studentsGrade)
        {
            studentsGrade += 3;
            Console.WriteLine("Student grade after extra credit is {0}", studentsGrade);
            
        }
//refernce
        public static void GiveExtraCreditArray(int[] grades)
        {
            grades[0] += 3;
            Console.WriteLine("The students array grade after extra credit is {0}", grades[0]);

        }
    }
}
