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
    }
}