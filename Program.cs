using System;

namespace params_keyword
{
    class Program
    {
//params allows to enter any amount of characters/argument
        static void Main(string[] args)
        {
            int[] myArray = { 3, 4, 5, 6, 7, 8, 9};
            PrintArray(myArray);
            PrintArray(3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 34, 23, 34);
        }
        public static void PrintArray(params int[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
