using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebuggingAndErrorHandling;

internal class CustomException : Exception
{
    public CustomException(ErrorType errorType) : base("my custom error message")
    {
		ErrorType = errorType;
	}
    public CustomException(ErrorType errorType, string msg) : base(msg)
	{
		ErrorType = errorType;
	}

	public ErrorType ErrorType { get; }
}

public enum ErrorType
{
    ClientError,
    ServerError,
    ResourceNotFound
}
