using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountApp.Exceptions
{
    internal class InvalidSsnExcpetion : Exception
    {
        public InvalidSsnExcpetion(string ssn) : base("SSN: " + ssn + " is not valid.")
        {
        }
    }
}
