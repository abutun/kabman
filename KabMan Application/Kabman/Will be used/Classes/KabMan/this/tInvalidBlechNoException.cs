using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KabMan.Client
{
    public class tInvalidBlechNoException : Exception
    {
        public tInvalidBlechNoException()
        {

        }
        public tInvalidBlechNoException(string argMessage)
            : base(argMessage)
        {

        }

        public tInvalidBlechNoException(string argMessage, Exception argException)
            : base(argMessage, argException)
        {

        }
    }
}
