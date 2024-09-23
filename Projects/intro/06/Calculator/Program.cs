using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("첫 번째 숫자를 입력하세요.");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("두 번째 숫자를 입력하세요.");
            int number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("연산자를 입력하세요.");
            string inputOperrator = Console.ReadLine();

            Console.Write(number1);
            Console.Write(inputOperrator);
            Console.Write(number2);
            Console.Write(" = ");

            if (inputOperrator == "+")
            {
                Console.WriteLine(number1 + number2);
            }
            else if (inputOperrator == "-")
            {
                Console.WriteLine(number1 - number2);
            }
            else if (inputOperrator == "*") 
            {
                Console.WriteLine(number1 * number2);
            }
            else if(inputOperrator == "/")
            {
                Console.WriteLine(number1 / number2);
            }
        }
    }
}