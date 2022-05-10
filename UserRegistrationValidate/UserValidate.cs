using System.Text.RegularExpressions;

namespace UserRegistrationValidate
{
    public class UserValidate
    {
        public const string _firstNameRegex = "^[A-Z]{1}[A-Za-z]{3,}$";
        public const string _lastNameRegex = "^[A-Z]{1}[A-Za-z]{3,}$";
        public const string _emailRegex = "^[0-9a-zA-Z]+[.+-_]{0,1}[0-9a-zA-Z]+[@][a-zA-Z]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3}){0,1}$";
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
        public string ValidateLastName(string lastName)
        {
            if (Regex.IsMatch(lastName, _lastNameRegex))
            {
                Console.WriteLine("LastName Matches.");
            }
            else
            {
                Console.WriteLine("Verify LastName Again.");
            }
            return lastName;
        }
        public string ValidateEmail(string eMail)
        {
            if (Regex.IsMatch(eMail, _emailRegex))
            {
                Console.WriteLine("Email Matches.");
            }
            else
            {
                Console.WriteLine("Verify Email Again.");
            }
            return eMail;
        }
    }
}