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
            bool result = userRegex.FirstNameRegex("Dilip");
            Assert.IsTrue(result);
        }
        [Test]
        public void FirstNameReturnFalse()
        {
            bool result = userRegex.FirstNameRegex("dilip");
            Assert.IsFalse(result);
        }
        [Test]
        public void LastNameReturnTrue()
        {
            bool result = userRegex.LastNameRegex("Rathod");
            Assert.IsTrue(result);
        }
        [Test]
        public void LastNameReturnFalse()
        {
            bool result = userRegex.LastNameRegex("rathod");
            Assert.IsFalse(result);
        }
    }
}