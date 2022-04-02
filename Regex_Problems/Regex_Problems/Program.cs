using System;
using System.Text.RegularExpressions;

namespace Regex_Problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your passward ");
            while (true)
            {
                string input = Console.ReadLine();
                Regex r = new Regex("^[A-Z][a-z]{7}$");

                if (r.IsMatch(input))
                {
                    Console.WriteLine("Your Password is " + true);
                }
                else
                {
                    Console.WriteLine("Your Passward is " + false);
                    Console.WriteLine("Please Take 1 Upper Case: ");
                }
            }
        }

    }
}

