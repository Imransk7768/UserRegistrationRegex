using System.Text.RegularExpressions;

namespace UserRegistrationValidate
{
    public class UserValidate
    {
        public const string _firstNameRegex = @"^[A-Z]{1}[A-Za-z]{3,}$";
        public const string _lastNameRegex = @"^[A-Z]{1}[A-Za-z]{3,}$";
        public const string _emailRegex = @"^[0-9a-zA-Z]+[.+-_]{0,1}[0-9a-zA-Z]+[@][a-zA-Z]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3}){0,1}$";
        public const string _mobileNumberRegex = "@^[+]{1}[1-9]{2}[-. ]{1}[1-9]{2}[0-9]{8}$";
        //public static string _passwordRegex = "^[a-zA-z0-9]{8,}$";
        //public static string _passwordmMinOneUpper = "^[A-Z]{1}[a-zA-Z]{8, }$";
        //public static string _passwordmMinOneUpperOneNo = "^[A-Z]{1}[a-z]{8, }[A-Z]{1, }[0-1]{1, }$";
        public static string _pwdWithOneUpperNoSpChar = "^[A-Z]{1, }[a-z]{8, }[A-Z]{1, }[0-1]{1, }[!*@#$%^&+=]{1}$";


        public string ValidateFirstName(string firstName)
        {
            try
            {
                if ((Regex.IsMatch(firstName, _firstNameRegex)) == false) 
                {
                    throw new UserExceptions(UserExceptions.ExceptionType.FIRST_NAME, "Plaese Enter FirstName With Min of Three chars.");
                }
                if ((Regex.IsMatch(firstName, _firstNameRegex)) == true) ;
                {
                    Console.WriteLine(firstName + " is a Valid User Account");
                    return firstName;
                }
            }
            catch (UserExceptions)
            {
                throw new UserExceptions(UserExceptions.ExceptionType.FIRST_NAME, "Plaese Verify FirstName.");
            }
        }
        public string ValidateLastName(string lastName)
        {
            try
            {
                if ((Regex.IsMatch(lastName, _lastNameRegex)) == false)
                {
                    throw new UserExceptions(UserExceptions.ExceptionType.LAST_NAME, "Plaese Enter LastName With Min of Three chars.");
                }
                if ((Regex.IsMatch(lastName, _lastNameRegex)) == true) ;
                {
                    Console.WriteLine(lastName + " is a Valid User Account");
                    return lastName;
                }
            }
            catch (UserExceptions)
            {
                throw new UserExceptions(UserExceptions.ExceptionType.LAST_NAME, "Plaese Verify LastName.");
            }
        }
        public string ValidateEmail(string eMail)
        {
            try
            {
                if ((Regex.IsMatch(eMail, _emailRegex)) == false)
                {
                    throw new UserExceptions(UserExceptions.ExceptionType.EMAIL_ADDRESS, "Plaese Enter Valid Email ID.");
                }
                if ((Regex.IsMatch(eMail, _emailRegex)) == true) ;
                {
                    Console.WriteLine(eMail + " is a Valid Email Id");
                    return eMail;
                }
            }
            catch (UserExceptions)
            {
                throw new UserExceptions(UserExceptions.ExceptionType.EMAIL_ADDRESS, "Plaese Verify Email.");
            }
        }
        public string ValidatePassword(string password)
        {
            try
            {
                if ((Regex.IsMatch(password, _pwdWithOneUpperNoSpChar)) == false)
                {
                    throw new UserExceptions(UserExceptions.ExceptionType.PASSWORD, "Plaese Enter Correct Password.");
                }
                if ((Regex.IsMatch(password, _pwdWithOneUpperNoSpChar)) == true) ;
                {
                    Console.WriteLine(password + " is a Valid Password");
                    return password;
                }
            }
            catch (UserExceptions)
            {
                throw new UserExceptions(UserExceptions.ExceptionType.PASSWORD, "Plaese Verify Password.");
            }
        }
        public string ValidateMobileNumber(string mobile)
        {
            try
            {
                if ((Regex.IsMatch(mobile, _mobileNumberRegex)) == false)
                {
                    throw new UserExceptions(UserExceptions.ExceptionType.MOBILE_NUMBER, "Plaese Enter Valid Mobile Number.");
                }
                if ((Regex.IsMatch(mobile, _mobileNumberRegex)) == true) ;
                {
                    Console.WriteLine(mobile + " is a Valid Mobile Number");
                    return mobile;
                }
            }
            catch (UserExceptions)
            {
                throw new UserExceptions(UserExceptions.ExceptionType.MOBILE_NUMBER, "Plaese Verify MobileNumber.");
            }
        }
    }
}