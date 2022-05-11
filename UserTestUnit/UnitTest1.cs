using NUnit.Framework;
using UserRegistrationValidate;

namespace UserTestUnit
{
    public class UnitTest1
    {
        [Test]
        public void InputString_TestUserFirstName()
        {
            UserValidate User = new UserValidate();
            string actual = User.ValidateFirstName("Rehan");
            Assert.AreEqual(actual, "Rehan");
        }

        [Test]
        public void InputString_TestUserLastName()
        {
            UserValidate user = new UserValidate();
            string actual = user.ValidateLastName("Shaik");
            Assert.AreEqual(actual, "Shaik");
        }

        [Test]
        public void InputString_TestUserEmail()
        {
            UserValidate user = new UserValidate();
            string actual = user.ValidateEmail("rehansk007@gmail.com");
            Assert.AreEqual(actual, "rehansk007@gmail.com");
        }

        [Test]
        public void InputString_TestUserMobile()
        {
            UserValidate user = new UserValidate();
            string actual = user.ValidateMobileNumber("9123456789");
            Assert.AreEqual(actual, "9123456789");
        }

        [Test]
        public void InputString_TestUserPassword()
        {
            UserValidate user = new UserValidate();
            string actual = user.ValidatePassword("drowssap");
            Assert.AreEqual(actual, "drowssap");
        }
        [Test]
        public void InputString_TestUserPassword_MinOneUpperCase()
        {
            UserValidate user = new UserValidate();
            string actual = user.PasswordMinOneUpper("Drowssap");
            Assert.AreEqual(actual, "Drowssap");
        }
        [Test]
        public void InputString_TestUserPassword_MinOneUpperOneNo()
        {
            UserValidate user = new UserValidate();
            string actual = user.PasswordMinOneUpperOneNo("Drowssap321");
            Assert.AreEqual(actual, "Drowssap321");
        }
    }
}