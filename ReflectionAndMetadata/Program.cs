Type t = typeof(int);

int age = 999;
Type dataTypeOfAge = age.GetType();

Type dataTypeOfInt = Type.GetType("System.Int32");

Console.WriteLine($"Is {t.Name} an array? {t.IsArray}");
Console.WriteLine($"The max value of an integer is {t.GetField("MaxValue").GetValue(default(int))}");