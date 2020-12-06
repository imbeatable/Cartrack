using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartrackaAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            bool endApp = false;
            Console.WriteLine("Welcome to Car Track Assignment");
            Console.WriteLine("-------------------------------\n");

            while (!endApp)
            {                
                Console.WriteLine("Please Enter Any Character");
                string char1 = Console.ReadLine();

                var isPalindrome = CheckPalindrome(char1);
                if (isPalindrome)
                {
                    Console.WriteLine("Word entered " + char1 + " is a Palindrome");
                    System.Threading.Thread.Sleep(1000);
                }
                else
                {
                    Console.WriteLine("Word entered " + char1 + " is not a Palindrome");
                    System.Threading.Thread.Sleep(1000);
                }

                Console.WriteLine("----------------------------\n");
                Console.WriteLine("Press 'c' and Enter to exit, or press any other key and Enter to continue: ");
                if (Console.ReadLine() == "c")
                {
                    endApp = true;
                }


                Console.WriteLine("\n");

            }



        }
        

        public static bool CheckPalindrome(string char1)
        {
            char[] chararray = char1.ToCharArray();
            char[] reversechar = new char[] { };

            for (int i = chararray.Count(); i > 0; i--)
            {
                reversechar = reversechar.Concat(new char[] { chararray[i - 1] }).ToArray();
            }
            string str = string.Join("", reversechar);

            if (char1 == str)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
