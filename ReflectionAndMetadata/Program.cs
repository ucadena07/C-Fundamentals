//Type t = typeof(int);

//int age = 999;
//Type dataTypeOfAge = age.GetType();

//Type dataTypeOfInt = Type.GetType("System.Int32");

//Console.WriteLine($"Is {t.Name} an array? {t.IsArray}");
//Console.WriteLine($"The max value of an integer is {t.GetField("MaxValue").GetValue(default(int))}");

//Example 1: Instantiating a class by the type
using ReflectionAndMetadata;

var personWithoutNameViaType = (Person)Activator.CreateInstance(typeof(Person));


//Example 2: Instantiating a class by the name and assembly
var fullNamePerson = typeof(Person).FullName;   
var assemblyOfPersonClass = typeof(Person).Assembly.GetName().Name;
var personWithoutNameViaString = (Person)Activator.CreateInstance(assemblyOfPersonClass, fullNamePerson).Unwrap();


//Example 3: Instantiating a class passing values to the constructor
var personWithNameViaType = (Person)Activator.CreateInstance(typeof(Person),new object[] {"Ulises"});

//Exmaple 4: Invoking a void parameterless method
var type = typeof(Utilities);
var utilities = Activator.CreateInstance(type);
type.InvokeMember("PrintCurrentTime", System.Reflection.BindingFlags.InvokeMethod,null,utilities,new object[] {});

//Exmaple 5: Invoking a parameter method
type.InvokeMember("PrintMessage", System.Reflection.BindingFlags.InvokeMethod, null, utilities, new object[] {"Using reflection" });

//Exmaple 6: Invoking a method with return value
var result = type.InvokeMember("GettingAValue", System.Reflection.BindingFlags.InvokeMethod, null, utilities, new object[] { });
Console.WriteLine($"We got the value {result}");


//Exmaple 7: Invoking a static method 
type.InvokeMember("StaticMethod", System.Reflection.BindingFlags.InvokeMethod, null, null, new object[] { });

//Exmaple 8: Invoking a private method 
type.InvokeMember("PrivateMethod", System.Reflection.BindingFlags.InvokeMethod | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance, null, utilities, new object[] { });