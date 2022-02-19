using System;

namespace Method_overload
{
    class Program
    {
        static void Main(string[] args)
        {
            Add(5, 10);
            Add("hello", "world");
            Add(3.0, 5.2);
        }
        public static void Add(int x, int y)
        {
            int answer = x + y;
            Console.WriteLine(answer);
        }
        public static void Add(string x, string y)
        {
            string answer = x + " " + y;
            Console.WriteLine(answer);
        }
        public static void Add(double x, double y)
        {
            double answer = x + y;
            Console.WriteLine(answer);
        }
    }
}
