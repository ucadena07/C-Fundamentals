//Type t = typeof(int);

//int age = 999;
//Type dataTypeOfAge = age.GetType();

//Type dataTypeOfInt = Type.GetType("System.Int32");

//Console.WriteLine($"Is {t.Name} an array? {t.IsArray}");
//Console.WriteLine($"The max value of an integer is {t.GetField("MaxValue").GetValue(default(int))}");

//Example 1: Instantiating a class by the type
using ReflectionAndMetadata;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

var personWithoutNameViaType = (Person)Activator.CreateInstance(typeof(Person));


//Example 2: Instantiating a class by the name and assembly
var fullNamePerson = typeof(Person).FullName;   
var assemblyOfPersonClass = typeof(Person).Assembly.GetName().Name;
var personWithoutNameViaString = (Person)Activator.CreateInstance(assemblyOfPersonClass, fullNamePerson).Unwrap();


//Example 3: Instantiating a class passing values to the constructor
var personWithNameViaType = (Person)Activator.CreateInstance(typeof(Person),new object[] {"Ulises"});

//Example 4: Invoking a void parameterless method
var type = typeof(Utilities);
var utilities = Activator.CreateInstance(type);
type.InvokeMember("PrintCurrentTime", System.Reflection.BindingFlags.InvokeMethod,null,utilities,new object[] {});

//Example 5: Invoking a parameter method
type.InvokeMember("PrintMessage", System.Reflection.BindingFlags.InvokeMethod, null, utilities, new object[] {"Using reflection" });

//Example 6: Invoking a method with return value
var result = type.InvokeMember("GettingAValue", System.Reflection.BindingFlags.InvokeMethod, null, utilities, new object[] { });
//Console.WriteLine($"We got the value {result}");


//Example 7: Invoking a static method 
type.InvokeMember("StaticMethod", System.Reflection.BindingFlags.InvokeMethod, null, null, new object[] { });

//Example 8: Invoking a private method 
type.InvokeMember("PrivateMethod", System.Reflection.BindingFlags.InvokeMethod | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance, null, utilities, new object[] { });
//Console.WriteLine("=========================");

//Example 9: Getting the base type
var baseTypeOfCar = typeof(Car).BaseType;
//Console.WriteLine($"The base type {baseTypeOfCar}");

//Example 10: Getting the interfaces
//Console.WriteLine($"The intefaces of STRING are: ");
foreach (var item in typeof(string).GetInterfaces())
{
    //Console.WriteLine(item);
}
//Example 11: Does a type inheret from a specific class or interface
var stringType = typeof(string);
var iEnumerableType= typeof(IEnumerable);
var stringImplementsIEnumerable = stringType.IsAssignableTo(iEnumerableType);
Console.WriteLine(stringImplementsIEnumerable);
Console.WriteLine("=========================");
var person = new Person();
person.Age = 17;
person.Salary = 20_000;
var errors = ValidateObject(person);
foreach (var error in errors)
{
    //Console.WriteLine($"Property: {error.Property};Error: {error.ErrorMessage}");
}

bool ValidatePerson(Person p)
{
    var type = p.GetType();
    var propertyAge = type.GetProperty("Age");
    if (propertyAge.IsDefined(typeof(RangeAttribute)))
    {
        var rangeAttr = (RangeAttribute)Attribute.GetCustomAttribute(propertyAge, typeof(RangeAttribute));
        return p.Age >= (int)rangeAttr.Minimum && p.Age <= (int)rangeAttr.Maximum;
    }
    return true;
}

IEnumerable<ValidationError> ValidateObject(object obj)
{
    var type = obj.GetType();
    var properties = type.GetProperties();
    var result = new List<ValidationError>();

    foreach (var property in properties)
    {
        if (property.IsDefined(typeof(RangeAttribute)))
        {
            var rangeAttr = (RangeAttribute)Attribute.GetCustomAttribute(property, typeof(RangeAttribute));
            var value = (int)property.GetValue(obj);
            var min = (int)rangeAttr.Minimum;
            var max = (int)rangeAttr.Maximum;   
            var isValid = value >= min && value <= max;
            if (!isValid)
            {
                result.Add(new()
                {
                    Property = property.Name,
                    ErrorMessage = $"The value should be between {min} and {max}"
                });
            }
        }
    }

    return result;
}
Console.WriteLine("=========================");

foreach (var action in Enum.GetValues<Actions>())
{
    var field = typeof(Actions).GetField(action.ToString());    
    var hideAttr = field.GetCustomAttribute(typeof(HideAttribute));
    if (hideAttr is not null)
    {
        var hide = ((HideAttribute)hideAttr).Hide();
        if (hide)
        {
            continue;
        }

    }
    Console.WriteLine(action);
}