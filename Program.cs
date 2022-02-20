using System;

namespace ooptional_parameters
{
    class Program
    {
        static void Main(string[] args)
        {
            Add(5);
            Add(4, 5, 5);
            Add(4, z: 5, y: 5);
            Add(4, z: 5);
        }
        public static void Add(int x, int y = 1, int z = 2)
        {
            int answer = x + y + z;
            Console.WriteLine(answer);
        }
    }
}
