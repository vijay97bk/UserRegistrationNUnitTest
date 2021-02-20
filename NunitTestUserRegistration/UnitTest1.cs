using NUnit.Framework;
using UserRegistrationUsingNUnitTest;
namespace UserRegistrationNUnitTest
{
    public class Tests
    {
        /// <summary>
        /// Arrange methodology- here we can declare variables class
        /// </summary>
        UserRegex userRegex;
        [SetUp]
        public void Setup()
        {
            userRegex = new UserRegex();
        }
        /// <summary>
        /// Act methodology- method calling 
        /// Assert methodology- here we can define the output 
        /// </summary>
        [Test]
        public void FirstNameReturnTrue()
        {
            bool result = userRegex.FirstNameRegex("Vijay");
            Assert.IsTrue(result);
        }
        [Test]
        public void FirstNameReturnFalse()
        {
            bool result = userRegex.FirstNameRegex("vijay");
            Assert.IsFalse(result);
        }
        [Test]
        public void LastNameReturnTrue()
        {
            bool result = userRegex.LastNameRegex("Kshirasagar");
            Assert.IsTrue(result);
        }
        [Test]
        public void LastNameReturnFalse()
        {
            //act
            bool result = userRegex.LastNameRegex("kshirasagar");
            //Assert
            Assert.IsFalse(result);
        }
        [Test]
        public void EmailReturnTrue()
        {
            bool result = userRegex.EmailRegex("abc.xyz@bl.co.in");
            Assert.IsTrue(result);
        }
        [Test]
        public void EmailReturnFalse()
        {
            bool result = userRegex.EmailRegex("abc.xyz@bl.co.in1");
            Assert.IsFalse(result);
        }

        [Test]
        public void MobileNumberRegexReturnTrue()
        {
            bool result = userRegex.MobileNumberRegex("91 9876543210");
            Assert.IsTrue(result);
        }
        [Test]
        public void MobileNumberRegexReturnFalse()
        {
            bool result = userRegex.MobileNumberRegex("91+ 9876543210");
            Assert.IsFalse(result);
        }
        [Test]
        public void PasswordRule1RegexReturnTrue()//Minimum 8 charachter
        {
            bool result = userRegex.PasswordRule1Regex("Admin@12&3$&");
            Assert.IsTrue(result);
        }
        [Test]
        public void PasswordRule1RegexReturnFalse()
        {
            bool result = userRegex.PasswordRule1Regex("Admin@1");
            Assert.IsFalse(result);
        }
        [Test]
        public void PasswordRule2RegexReturnTrue()//atleast 1 uppercase character-all rules passed
        {
            bool result = userRegex.PasswordRule2Regex("ad$$&didDdsfsn41");
            Assert.IsTrue(result);
        }
        [Test]
        public void PasswordRule2RegexReturnFalse()
        {
            bool result = userRegex.PasswordRule2Regex("ad$$&di");
            Assert.IsFalse(result);
        }
        [Test]
        public void PasswordRule3RegexReturnTrue()//atleast 1 numeric number 
        {
            bool result = userRegex.PasswordRule3Regex("ad$$&did3Ddsfsn");
            Assert.IsTrue(result);
        }
        [Test]
        public void PasswordRule3RegexReturnFalse()
        {
            bool result = userRegex.PasswordRule3Regex("ad$$&didDdsfsn");
            Assert.IsFalse(result);
        }
        [Test]
        public void PasswordRule4RegexReturnTrue()//exactly 1 special character
        {
            bool result = userRegex.PasswordRule4Regex("aff&sdfA9");
            Assert.IsTrue(result);
        }
        [Test]
        public void PasswordRule4RegexReturnFalse()
        {
            bool result = userRegex.PasswordRule4Regex("affsdfA9");
            Assert.IsFalse(result);
        }
    }
}