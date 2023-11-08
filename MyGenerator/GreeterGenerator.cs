using Microsoft.CodeAnalysis;
using System;

namespace MyGenerator
{
    [Generator]
    public class GreeterGenerator : ISourceGenerator
    {
        public void Execute(GeneratorExecutionContext context)
        {
            var sourceCode = @"
namespace ReflectionAndMetadata
{
    static partial class Greeter
    {
        static partial void GeneratedGreet(string name) => Console.WriteLine($""Gretting from {name}"");
    }
}";
            context.AddSource("Greeter.g.cs",sourceCode);
        }

        public void Initialize(GeneratorInitializationContext context)
        {

        }
    }
}


