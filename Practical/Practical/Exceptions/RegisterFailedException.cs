using Practical.Helpers.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical.Exceptions
{
    internal class RegisterFailedException : Exception
    {
        public RegisterFailedException() : this(AccountMessages.RegisterFailed)
        {
            
        }
        public RegisterFailedException(string msj) : base(msj)
        {
            
        }
    }
}
