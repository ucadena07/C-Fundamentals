using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP;

internal interface IMyInterface
{
    void Method1();
    
    string Method2(int param1);
    bool MyProperty { get; set; }
    int MyReadOnlyProp { get; }
}

internal interface IMySecondInterface
{
    void MethodFromSecondInterface();
}

public class MyClassWithAnInterface : IMyInterface, IMySecondInterface
{
    public bool MyProperty { get ; set; }

    public int MyReadOnlyProp => 42;

    public void Method1()
    {
        Console.WriteLine("This is method 1");
    }

    public string Method2(int param1)
    {
        return $"the param passed was {param1}";
    }

    public void MethodFromSecondInterface()
    {
        Console.WriteLine("Method from second interface");
    }
}
internal struct MyStruct : IMySecondInterface
{
    public void MethodFromSecondInterface()
    {
        throw new NotImplementedException();
    }
}

internal record MyRecord(string param1) : IMySecondInterface
{
    public void MethodFromSecondInterface()
    {
        throw new NotImplementedException();
    }
}