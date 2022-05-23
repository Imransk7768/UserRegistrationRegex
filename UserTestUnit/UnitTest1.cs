using NUnit.Framework;
using System;
using UserRegistrationValidate;

namespace UserTestUnit
{
    public class UnitTest1
    {
        UserValidate user = new UserValidate();
        [Test]
        public void InputString_TestUserFirstName()
        {
            try
            {
                string result = user.ValidateFirstName("Rehan");
                Assert.AreEqual(result, "Rehan");
            }
            catch (UserExceptions ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        [Test]
        public void InputString_TestUserLastName()
        {
            try
            {
                string result = user.ValidateLastName("Shaik");
                Assert.AreEqual(result, "Shaik");
            }
            catch (UserExceptions ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        [Test]
        public void InputString_TestUserEmail()
        {
            try
            {
                string result = user.ValidateLastName("rehan.shaik@gmail.co.in");
                Assert.AreEqual(result, "rehan.shaik@gmail.co.in");
            }
            catch (UserExceptions ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        [Test]
        public void InputString_TestUserMobile()
        {
            try
            {
                string result = user.ValidateMobileNumber("+91 9012345678");
                Assert.AreEqual(result, "+91 9012345678");
            }
            catch (UserExceptions ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        [Test]
        public void InputString_TestUserPassword()
        {
            try
            {
                string result = user.ValidatePassword("Drowssap#321");
                Assert.AreEqual(result, "Drowssap#321");
            }
            catch (UserExceptions ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}