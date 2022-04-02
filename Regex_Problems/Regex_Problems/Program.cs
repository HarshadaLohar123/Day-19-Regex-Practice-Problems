using System;
using System.Text.RegularExpressions;

namespace Regex_Problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your password with one Upper,one numberic,one special character: ");
            while (true)
            {
                string input = Console.ReadLine();
                Regex r = new Regex(@"^[A-Z][0-9](|_|.|-|~|@|)[a-z]{5}$");
                if (r.IsMatch(input))
                {
                    Console.WriteLine("Password is " + true);
                }
                else
                {
                    Console.WriteLine("Password is " + false);
                }

            }
        }

    }
}

