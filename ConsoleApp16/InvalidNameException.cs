using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    public class InvalidNameException : ApplicationException
    {
        public InvalidNameException()
        {

        }
        public InvalidNameException(string message) : base(message)
        {

        }
    }
}
