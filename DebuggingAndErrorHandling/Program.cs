using DebuggingAndErrorHandling;
using System.ComponentModel;
using System.Diagnostics;

try
{
	throw new CustomException(ErrorType.ResourceNotFound);
}
catch (CustomException ex) when (ex.ErrorType == ErrorType.ClientError)
{

  Console.WriteLine("client error");
}
catch (CustomException ex) when (ex.ErrorType == ErrorType.ServerError)
{
	Console.WriteLine("server error");

}
catch (CustomException ex) when (ex.ErrorType == ErrorType.ResourceNotFound)
{

	Console.WriteLine("resource not found error");
}



var myWritter = new TextWriterTraceListener(Console.Out);
Trace.Listeners.Add(myWritter);

Debug.WriteLine("This message will only appear in debug mode");

Debug.WriteLine("==================");
var test = 1;
test++;

Add(5,6);

int Add(int a, int b)
{
    int c = a + b;
    return c;
}

void MethodA()
{

}

void MethodB()
{

}


MethodB();
MethodA();
MethodB();


void Process(int a, string name)
{
    var tupple = (a, name);
    a = 3;
    int b = a + 4;
    b -= 4;
    int[] numbers = {1,2,3,4,5,6,7};
}

Process(7, "Ulises");

try
{
	ClassA.ProcessA();
}
catch (Exception ex)
{

	Console.WriteLine("more processing");

	Console.WriteLine(ex.Message);
}


internal class ClassA
{
    public static void ProcessA()
    {
        try
        {
            throw new NotImplementedException();
        }
        catch (Exception ex)
        {

            Console.WriteLine("Processing exp");
            throw;   
        }
    }
}

internal class ClassB
{
    public static void ProcessB()
    {
        ClassC.ProcessC();
    }

}

internal class ClassC
{
    public static void ProcessC()
    {
        throw new Exception();
    }
}



