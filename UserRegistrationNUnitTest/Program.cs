using System;
using System.Text.RegularExpressions;

namespace UserRegistrationUsingNUnitTest
{
    public class UserRegex
    {
        Regex firstNameregex = new Regex("^[A-Z][a-zA-Z]{2,}$");
        public bool FirstNameRegex(string firstname)
        {
            return (firstNameregex.IsMatch(firstname));
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to user registration NUnit testing");
        }
    }
}