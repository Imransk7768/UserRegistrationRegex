using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationValidate
{
    public class UserExceptions: Exception
    {
        public enum ExceptionType
        {
            FIRST_NAME, LAST_NAME, EMAIL_ADDRESS, MOBILE_NUMBER, PASSWORD
        }
        public ExceptionType exceptionType;
        public UserExceptions(ExceptionType type, string message) : base(message)
        {
            this.exceptionType = type;
        }
    }
}
