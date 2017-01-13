using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PalindromeNumbers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            countNumberPalindromes();
            verifyStringPalindrome();
            Console.ReadLine();
        }

        public static void countNumberPalindromes()
        {
            int count = 0;
            int y = 0;
            int maxCount;

            Console.WriteLine("How many palindrome numbers would you like to see?");

            while (!int.TryParse(Console.ReadLine(), out maxCount) || maxCount <= 0)
            {
                Console.WriteLine("Please enter a positive integer");
            }

            do
            {
                if (isPalindrome(y))
                {
                    Console.WriteLine(y);
                    count++;
                }
                y++;
            }
            while (count < maxCount);

        }
        public static bool isPalindrome(int z)
        {
            return z.ToString().Reverse().SequenceEqual(z.ToString());
        }

        public static bool isPalindrome(string z)
        {
            return z.Reverse().SequenceEqual(z);
        }

        public static void verifyStringPalindrome()
        {
            string test;
            do
            {
                Console.WriteLine("Enter any sequence of characters:");
                test = Console.ReadLine();
                if (isPalindrome(test))
                {
                    Console.WriteLine("{0} is a palindrome", test);
                }
                else
                {
                    Console.WriteLine("{0} is not a palidrome", test);
                }
            }
            while (test.ToLower() != "exit");
            Console.WriteLine("Thanks for playing. Goodbye!");
        }
    }

}
