using System;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;

namespace Homework_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 2;

            Console.WriteLine(BasicOp('+', a, b));
            Console.WriteLine(BasicOp('-', a, b));
            Console.WriteLine(BasicOp('*', a, b));
            Console.WriteLine(BasicOp('/', a, b));

            Console.WriteLine(ConvertToBin(1800, 56));

        }
        static string ConvertToBin(int a, int b)
        {
            int numToConvert = a + b;
            string binary = Convert.ToString(numToConvert, 2);
            Console.WriteLine("\nBinary");
            return binary;
        }

        static int BasicOp(char c, int a, int b)
        {
            var op = 0;

            if (c == '+')
            {
                Console.WriteLine("Addition");
                op = a + b;
                return op;
            }
            else
                if (c == '-')
            {
                Console.WriteLine("\nSubstraction");
                op = a - b;
                return op;
            }
            else
                if (c == '*')
            {
                Console.WriteLine("\nMultiplication");
                op = a * b;
                return op;
            }
            else
                if (c == '/')
            {
                Console.WriteLine("\nDivision");
                op = a / b;
                return op;
            }
            else
                Console.WriteLine("ERROR");
                Console.WriteLine("Wrong operator!");
                return op;

        }
    }
}