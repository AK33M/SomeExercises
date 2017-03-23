using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            bool result = IsPalindrome("Akeem");
            Console.WriteLine("Palindrome: " + result);
            Console.WriteLine("**********");
            result = IsPalindrome("Hannah");
            Console.WriteLine("Palindrome: " + result);
            Console.WriteLine("**********");
            result = IsPalindrome("John");
            Console.WriteLine("Palindrome: " + result);
            Console.WriteLine("**********");
            result = IsPalindrome(15693);
            Console.WriteLine("Palindrome: " + result);
            Console.WriteLine("**********");
            result = IsPalindrome(159951);
            Console.WriteLine("Palindrome: " + result);
        }

        private static bool IsPalindrome(int input)
        {
            var result = ReverseInt(input);
            Console.WriteLine("Input is: " + input);
            Console.WriteLine("Reverse is: " + result);
            if (input == result)
            {
                return true;
            }

            return false;
        }

        private static bool IsPalindrome(string input)
        {
            var result = ReverseStringA(input);
            Console.WriteLine("Input is: " + input);
            Console.WriteLine("Reverse A is: " + result);
            var resultb = ReverseStringB(input);
            Console.WriteLine("Reverse B is: " + resultb);
            var resultc = ReverseStringC(input);
            Console.WriteLine("Reverse C is: " + resultc);
            if (input.ToLower() == result.ToLower())
            {
                return true;
            }

            return false;
        }

        private static string ReverseStringA(string input)
        {
            var reverse = new StringBuilder();
            var charArray = input.ToCharArray();

            for (int i = charArray.Length - 1; i >= 0; i--)
            {
                reverse.Append(charArray[i]);
            }

            return reverse.ToString();
        }

        private static string ReverseStringB(string input)
        {
            var reverse = new StringBuilder();
            var charArray = input.ToCharArray();
            var temp = '.';
            var lastIndex = charArray.Length - 1;

            for (int i = 0; i < charArray.Length/2; i++)
            {
                temp = charArray[lastIndex - i];
                charArray[lastIndex - i] = charArray[i];
                charArray[i] = temp;                
            }

            return reverse.Append(charArray).ToString();
        }

        private static string ReverseStringC(string input)
        {
            if (input.Length < 2)
                return input;

            return ReverseStringC(input.Substring(1)) + input.ToCharArray()[0];
        }

        private static int ReverseInt(int number)
        {
            int reverse = 0;

            while (number != 0)
            {
                reverse = reverse * 10 + number % 10;
                number = number / 10;
            }

            return reverse;
        }
    }
}
