using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_.NET_Core_HW
{
    class LoginLetterException : ApplicationException
    {
        public LoginLetterException(string message)
            : base(message)
        {

        }
    }
    class SalarySymbolException : ApplicationException
    {
        public SalarySymbolException(string message)
            : base(message)
        {

        }
    }
    class NullException : ApplicationException
    {
        public NullException(string message)
            : base(message)
        {

        }
    }
    class OutOfRangeEmployeeArray : ApplicationException
    {
        public OutOfRangeEmployeeArray(string message)
            : base(message)
        {

        }
    }
    class EmptyArrayEmployees : ApplicationException
    {
        public EmptyArrayEmployees(string message)
            : base(message)
        {

        }
    }
}
