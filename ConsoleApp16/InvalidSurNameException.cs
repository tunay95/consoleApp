using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    public class InvalidSurNameException : ApplicationException
    {
        public InvalidSurNameException()
        {

        }
        public InvalidSurNameException(string message) : base(message)
        {

        }
    }
}
