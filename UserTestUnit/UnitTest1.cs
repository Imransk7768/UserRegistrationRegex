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
    }
}