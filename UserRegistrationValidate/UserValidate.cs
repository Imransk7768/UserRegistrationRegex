using System.Text.RegularExpressions;

namespace UserRegistrationValidate
{
    public class UserValidate
    {
        public const string _firstNameRegex = @"^[A-Z]{1}[A-Za-z]{3,}$";
        public const string _lastNameRegex = @"^[A-Z]{1}[A-Za-z]{3,}$";
        public const string _emailRegex = @"^[0-9a-zA-Z]+[.+-_]{0,1}[0-9a-zA-Z]+[@][a-zA-Z]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3}){0,1}$";
        public const string _mobileNumberRegex = "@^[+]{1}[1-9]{2}[-. ]{1}[1-9]{2}[0-9]{8}$";
        public static string _passwordRegex = "^[a-zA-z0-9]{8,}$";
        public static string _passwordmMinOneUpper = "^[A-Z]{1}[a-zA-Z]{8, }$";
        public static string _passwordmMinOneUpperOneNo = "^[A-Z]{1}[a-z]{8, }[A-Z]{1, }[0-1]{1, }$";
        public static string _pwdWithOneUpperNoSpChar = "^[A-Z]{1, }[a-z]{8, }[A-Z]{1, }[0-1]{1, }[!*@#$%^&+=]{1}$";

        public bool ValidateFirstName(string firstName)=>(Regex.IsMatch(firstName, _firstNameRegex));
        public bool ValidateLastName(string lastName) => (Regex.IsMatch(lastName, _lastNameRegex));
        public bool ValidateMobileNumber(string mobile) => (Regex.IsMatch(mobile, _mobileNumberRegex));
        public bool ValidateEmail(string eMail) => (Regex.IsMatch(eMail, _emailRegex));
        public bool ValidatePassword(string password) => (Regex.IsMatch(password, _passwordRegex));
        public bool PasswordMinOneUpper(string password1) => (Regex.IsMatch(password1, _passwordmMinOneUpper));
        public bool PasswordMinOneUpperOneNo(string password2) => (Regex.IsMatch(password2, _passwordmMinOneUpperOneNo));
        public bool PwdMinOneNo_Upper_SplChar(string password3) => (Regex.IsMatch(password3, _pwdWithOneUpperNoSpChar));
    }
}