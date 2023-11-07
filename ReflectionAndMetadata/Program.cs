//Type t = typeof(int);

//int age = 999;
//Type dataTypeOfAge = age.GetType();

//Type dataTypeOfInt = Type.GetType("System.Int32");

//Console.WriteLine($"Is {t.Name} an array? {t.IsArray}");
//Console.WriteLine($"The max value of an integer is {t.GetField("MaxValue").GetValue(default(int))}");

//Example 1: Instantiating a class by the type
using ReflectionAndMetadata;

var personWithoutNameViaType = (Person)Activator.CreateInstance(typeof(Person));


//Example 1: Instantiating a class by the name and assembly
var fullNamePerson = typeof(Person).FullName;   
var assemblyOfPersonClass = typeof(Person).Assembly.GetName().Name;
var personWithoutNameViaString = (Person)Activator.CreateInstance(assemblyOfPersonClass, fullNamePerson).Unwrap();
Console.WriteLine($"Person instantiated by its name {personWithoutNameViaString}");