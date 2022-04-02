using System;
using System.Text.RegularExpressions;

namespace Regex_Problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter your First name");

            while (true)
            {
                string input = Console.ReadLine();
                Regex r = new Regex("^[A-Z][a-z]{2,}$");
                if (r.IsMatch(input))
                {
                    Console.WriteLine("your First name is " + true);
                }
                else
                {
                    Console.WriteLine("Your First name is " + false);
                    Console.WriteLine("First Name Should Contain Only Four Character");
                }
            }
        }
    }
}
