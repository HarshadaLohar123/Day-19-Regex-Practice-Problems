using System;
using System.Text.RegularExpressions;

namespace Regex_Problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter your Last Name");

            while (true)
            {
                string input = Console.ReadLine();
                Regex r = new Regex("^[A-Z][a-z]{2}$");
                if (r.IsMatch(input))
                {
                    Console.WriteLine("your Last Name Is " + true);
                }
                else
                {
                    Console.WriteLine("Your Last Name Is " + false);
                    Console.WriteLine("Last Name Should Contain Only Four Character");
                }
            }
        }
    }
}
