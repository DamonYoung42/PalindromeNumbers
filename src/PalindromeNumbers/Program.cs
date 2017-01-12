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
            int count = 0;
            int y = 0;
 
            do
            {
                if (y.ToString().Reverse().SequenceEqual(y.ToString()))
                {
                    Console.WriteLine(y);
                    Console.ReadLine();
                    count++;
                }
                y++;
            }
            while (count < 2000);
            Console.WriteLine(count);
            Console.ReadLine();
        }
    }
}
