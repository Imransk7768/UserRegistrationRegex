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
        [Test]
        public void InputString_TestUserPasswordWithSpecialChar()
        {
            UserValidate user = new UserValidate();
            string actual = user.PwdMinOneNo_Upper_SplChar("Drowssap#321");
            Assert.AreEqual(actual, "Drowssap321#");
        }
        [Test]
        public void InputString_TestUserEmailSamples()
        {
            UserValidate user = new UserValidate();
            bool email1 = user.CheckEmail("rehanshaik123@gmail.com.in");
            bool email2 = user.CheckEmail("abc@yahoo.com");
            bool email3 = user.CheckEmail("abc-100@yahoo.com");
            bool email4 = user.CheckEmail("abc.100@yahoo.com");
            bool email5 = user.CheckEmail("abc111@abc.com");
            bool email6 = user.CheckEmail("abc-100@abc.net");
            bool email7 = user.CheckEmail("abc.100@abc.com.au");
            bool email8 = user.CheckEmail("abc@1.com");
            bool email9 = user.CheckEmail("abc@gmail.com.com");
            bool email10 = user.CheckEmail("abc+100@gmail.com");
            Assert.IsTrue(email1);
            Assert.IsTrue(email1);
            Assert.IsTrue(email2);
            Assert.IsTrue(email3);
            Assert.IsTrue(email4);
            Assert.IsTrue(email5);
            Assert.IsTrue(email6);
            Assert.IsTrue(email7);
            Assert.IsTrue(email8);
            Assert.IsTrue(email9);
            Assert.IsTrue(email10);
        }
    }
}