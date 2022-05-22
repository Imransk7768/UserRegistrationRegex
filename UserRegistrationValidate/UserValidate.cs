using System.Text.RegularExpressions;

namespace UserRegistrationValidate
{
    public class UserValidate
    {
        public const string _firstNameRegex = "^[A-Z]{1}[A-Za-z]{3,}$";
        public const string _lastNameRegex = "^[A-Z]{1}[A-Za-z]{3,}$";
        public const string _emailRegex = "^[0-9a-zA-Z]+[.+-_]{0,1}[0-9a-zA-Z]+[@][a-zA-Z]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3}){0,1}$";
        public const string _mobileNumberRegex = "^[6-9]{1}[0-9]{9}$";
        public static string _passwordRegex = "^[a-zA-z0-9]{8,}$";
        public static string _passwordmMinOneUpper = "^[A-Z]{1}[a-zA-Z]{8, }$";
        public static string _passwordmMinOneUpperOneNo = "^[A-Z]{1}[a-z]{8, }[A-Z]{1, }[0-1]{1, }$";
        public static string _pwdWithOneUpperNoSpChar = "^[A-Z]{1, }[a-z]{8, }[A-Z]{1, }[0-1]{1, }[!*@#$%^&+=]{1}$";

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
        public string ValidateMobileNumber(string mobile)
        {
            if (Regex.IsMatch(mobile, _mobileNumberRegex))
            {
                Console.WriteLine("Mobile No Matches.");
            }
            else
            {
                Console.WriteLine("Verify Mobile No Again.");
            }
            return mobile;
        }
        public string ValidatePassword(string password)
        {
            if (Regex.IsMatch(password, _passwordRegex))
            {
                Console.WriteLine("Password No Matches.");
            }
            else
            {
                Console.WriteLine("Verify Password No Again.");
            }
            return password;
        }
        public string PasswordMinOneUpper(string passwordd)
        {
            if (Regex.IsMatch(passwordd, _pwdWithOneUpperNoSpChar))
            {
                Console.WriteLine("Password Matches.");
            }
            else
            {
                Console.WriteLine("Verify Password Again.");
            }
            return passwordd;
        }
        public string PasswordMinOneUpperOneNo(string passworrd)
        {
            if (Regex.IsMatch(passworrd, _passwordmMinOneUpperOneNo))
            {
                Console.WriteLine("Password Matches.");
            }
            else
            {
                Console.WriteLine("Verify Password Again.");
            }
            return passworrd;
        }
        public string PwdMinOneNo_Upper_SplChar(string passwords)
        {
            if (Regex.IsMatch(passwords, _passwordmMinOneUpperOneNo))
            {
                Console.WriteLine("Password Matches.");
            }
            else
            {
                Console.WriteLine("Verify Password Again.");
            }
            return passwords;
        }
        public bool CheckEmail(string email)
        {
            return Regex.IsMatch(email, _emailRegex);
        }
        public string ValidateEmailData(string eMail)
        {
            if (Regex.IsMatch(eMail, _emailRegex))
            {
                Console.WriteLine("Email Matches");
            }
            else
            {
                Console.WriteLine("Verify Email.");
            }
            return eMail;
        }
    }
}