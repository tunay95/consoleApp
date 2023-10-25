using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    public class InvalidPasswordException : ApplicationException
    {
        public InvalidPasswordException()
        {

        }
        public InvalidPasswordException(string message) : base(message)
        {

        }
    }
}
