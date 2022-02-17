using System;

namespace Udemyyyyy
{
	class Program
	{
		static void Main(string[] args)
        {

      //Method
            int answer = Add(5, 10);
            int secondAnswer = Add(answer, 5);
            Console.WriteLine(secondAnswer);
            int a = int.Parse(Console.ReadLine());
        }
//Methods
        public static int Add(int number1, int number2)

        {
            int answer = number1 + number2;
            return answer;
        }
    }
}
