using System;
using System.Text.RegularExpressions;

namespace UserRegistrationUsingNUnitTest
{
    public class UserRegex
    {
        Regex firstNameregex = new Regex("^[A-Z][a-zA-Z]{2,}$");
        Regex lastNameregex = new Regex("^[A-Z][a-zA-Z]{2,}$");
        public bool FirstNameRegex(string firstname)
        {
            return (firstNameregex.IsMatch(firstname));
        }

        public bool LastNameRegex(string lastName)
        {
            return (lastNameregex.IsMatch(lastName));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to user registration NUnit testing");
        }
    }
}