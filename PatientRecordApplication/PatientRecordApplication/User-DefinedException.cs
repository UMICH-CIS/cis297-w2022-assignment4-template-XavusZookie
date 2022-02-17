using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// user defined exception is what i made to be thrown when given a negative number since these numbers should only be positive
/// it takes a message when it is thrown and inherits from the base exception class
/// </summary>
namespace PatientRecordApplication
{
    class User_DefinedException : Exception
    {

        public User_DefinedException()
            : base("   ")
        { 

        }

        public User_DefinedException(string messageValue)
            : base(messageValue)
        {

        }

        public User_DefinedException(string messageValue, Exception inner)
            : base(messageValue, inner)
        {

        }

    }

    public class userdefinedexception
    {
    }
}
