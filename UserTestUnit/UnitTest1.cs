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
                bool fName = user.ValidateFirstName("Rehan");
            }
            catch (UserExceptions ex)
            {
                Assert.AreEqual(ex.Message, "Invalid FirstName");
                Console.WriteLine(ex.Message);
            }
        }
        [Test]
        public void InputString_TestUserLastName()
        {
            try
            {
                bool lName = user.ValidateLastName("Shaik");
            }
            catch (UserExceptions ex)
            {
                Assert.AreEqual(ex.Message, "Invalid LastName");
                Console.WriteLine(ex.Message);
            }
        }
        [Test]
        public void InputString_TestUserEmail()
        {
            try
            {
                bool eMl = user.ValidateEmail("rehan.shaik@gmail.co.in");
            }
            catch (UserExceptions ex)
            {
                Assert.AreEqual(ex.Message, "Invalid EMail");
                Console.WriteLine(ex.Message);
            }
        }
        [Test]
        public void InputString_TestUserMobile()
        {
            try
            {
                bool mob = user.ValidateMobileNumber("+91 9012345678");
            }
            catch (UserExceptions ex)
            {
                Assert.AreEqual(ex.Message, "Invalid Mobile");
                Console.WriteLine(ex.Message);
            }
        }
        [Test]
        public void InputString_TestUserPassword()
        {
            try
            {
                bool mob = user.ValidatePassword("drowssap");
            }
            catch (UserExceptions ex)
            {
                Assert.AreEqual(ex.Message, "Invalid Password");
                Console.WriteLine(ex.Message);
            }
        }
        [Test]
        public void InputString_TestUserPasswordMinOneUpper()
        {
            try
            {
                bool mob = user.PasswordMinOneUpper("Drowssap");
            }
            catch (UserExceptions ex)
            {
                Assert.AreEqual(ex.Message, "Invalid Password");
                Console.WriteLine(ex.Message);
            }
        }
        [Test]
        public void InputString_TestUserPasswordMinOneUpperOneNo()
        {
            try
            {
                bool mob = user.PasswordMinOneUpperOneNo("Drowssap321");
            }
            catch (UserExceptions ex)
            {
                Assert.AreEqual(ex.Message, "Invalid Password");
                Console.WriteLine(ex.Message);
            }
        }
        [Test]
        public void InputString_TestUserPasswordWithOneUpperNoSpChar()
        {
            try
            {
                bool mob = user.PwdMinOneNo_Upper_SplChar("Drowssap@321");
            }
            catch (UserExceptions ex)
            {
                Assert.AreEqual(ex.Message, "Invalid Password");
                Console.WriteLine(ex.Message);
            }
        }
    }
}