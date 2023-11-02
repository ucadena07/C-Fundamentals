using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebuggingAndErrorHandling;

internal class CustomException : Exception
{
    public CustomException() : base("my custom error message")
    {
            
    }
    public CustomException(string msg) : base(msg) { }
}
