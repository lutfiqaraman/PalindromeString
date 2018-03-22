using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input your string");
            string str = Console.ReadLine();
            
            PalindromeString strPalindrome = new PalindromeString(str);
            
            if (strPalindrome.CheckPalindrome(str))
                Console.WriteLine("{0} is a palindrome string", str);
            else
                Console.WriteLine("{0} is not a palindrome string", str);
            
            Console.ReadKey();
        }
    }
}
