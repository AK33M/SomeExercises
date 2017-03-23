using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Ask user for legth of series
            string input = args[0];
            string type = "";


            int length = int.Parse(input);

            if (length != 0)
            {
                switch (type)
                {
                    case "R":
                        Console.WriteLine("Fibonacci Series By both Recursive method");
                        for (int i = 1; i <= length; i++)
                        {
                            Console.Write(FibonacciByRecursion(i) + " ");
                        }
                        break;
                    case "I":
                        Console.WriteLine("Fibonacci Series By both Iterative method");
                        for (int i = 1; i <= length; i++)
                        {
                            Console.Write(FibonacciByIteration(i) + " ");
                        }
                        break;
                    default:
                        Console.WriteLine("Fibonacci Series By both Recursive and Iterative methods");
                        for (int i = 1; i <= length; i++)
                        {
                            Console.Write(FibonacciByRecursion(i) + " *");
                        } 
                        Console.WriteLine(" ");
                        for (int i = 1; i <= length; i++)
                        {
                            Console.Write(FibonacciByRecursion(i) + " .");
                        }
                        break;
                }
            }
        }

        private static int FibonacciByRecursion(int number)
        {
            if (number == 1 || number == 2)
            {
                return 1;
            }

            return FibonacciByRecursion(number - 1) + FibonacciByRecursion(number - 2);
        }

        private static int FibonacciByIteration(int number)
        {
            if (number == 1 || number == 2)
            {
                return 1;
            }

            int numA = 1, numB = 1, numResult = 1;

            for (int i = 3; i <= number; i++)
            {
                numResult = numA + numB;
                numA = numB;
                numB = numResult;
            }

            return numResult;
        }
    }
}
