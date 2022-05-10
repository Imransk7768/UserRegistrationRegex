using System.Text.RegularExpressions;

namespace UserRegistrationValidate
{
    public class UserValidate
    {
        public const string _firstNameRegex = "^[A-Z]{1}[A-Za-z]{3,}$";
        public string ValidateFirstName(string firstName)
        {
            if (Regex.IsMatch(firstName, _firstNameRegex))
            {
                Console.WriteLine("First Name Matches.");
            }
            else
            {
                Console.WriteLine("Verify FirstName Again.");
            }
            return firstName;
        }
    }
}