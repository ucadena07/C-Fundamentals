//Simple fuction
using System.Diagnostics;
using System.Reflection;

string GetName()
{
    return "Ulises";
}

//No return value
void PrintCurrentTime()
{
   // Console.WriteLine(DateTime.Now);
}

GetName();
PrintCurrentTime();

//passing data
double Average(int[] numbers)
{
    var sum = 0.0;
    foreach (var number in numbers)
    {
        sum += number;
    }
    return sum /numbers.Length;
}

//Console.WriteLine(Average(new int[] { 1,5,7,2}));

double Average2(params int[] numbers)
{
    var sum = 0.0;
    foreach (var number in numbers)
    {
        sum += number;
    }
    return sum / numbers.Length;
}


//Console.WriteLine(Average2(1, 5, 7, 2));


//passing a value type
int num1 = 5;

void Double(ref int n)
{
    n *= 2;
    Console.WriteLine($"the value inside is : {n}");
}


//Console.WriteLine($"the value outside is : {num1}");
//Double(ref num1);
//Console.WriteLine($"the value outside is : {num1}");

//passing a ref type

void DoubleArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] *= 2;
    }
}

void PrintArray(int[] numbers)
{
    foreach (var item in numbers)
    {
        Console.WriteLine($"{item}");
    }
}

var oArray = new int[] { 5, 10, 20 };

PrintArray(oArray);
DoubleArray(oArray);
Console.WriteLine("===============");
PrintArray(oArray);

//out parameter
int numberToDouble = 5;
int doubleNumber;

void DoubleOut(int n, out int doubled)
{
    doubled = n * 2;    
}

DoubleOut(numberToDouble, out doubleNumber);

Console.WriteLine($"original number: {numberToDouble}");
Console.WriteLine($"modified number: {doubleNumber}");

//returning several values 
void DoubleAndTriple(int number, out int  doubledNumber, out int tripleNumber)
{
    doubledNumber = number * 2;
    tripleNumber = number * 3;
}

int doubled, tripled;
DoubleAndTriple(7, out doubled, out tripled);
Console.WriteLine("============");
Console.WriteLine(doubled);
Console.WriteLine(tripled);
Console.WriteLine("============");

//Tuples
(int rate,int random, string name) myTupple = (99, 45, "Nigel");
Console.WriteLine(myTupple);
Console.WriteLine(myTupple.name);

Console.WriteLine("============");
(int newRate, int dangerousRate) Rates(int value)
{
    return (value * 2, value * 3);
}

var result = Rates(10);
Console.WriteLine(result);
Console.WriteLine(result.newRate);
Console.WriteLine(result.dangerousRate);
Console.WriteLine("============");

//local function
void myFunction()
{
    var value = 5;
    PrintValue(value);
    value++;
    PrintValue(value);

    void PrintValue(int value)
    {
        Console.WriteLine($"The value is {value}");
    }
}
myFunction();
Console.WriteLine("============");

//Lambda Expressions
int Sum(int a, int b)
{
    return a + b;
}

int Sum2(int a, int b) => a + b;

//Actions - void functions that doesnt receive parameters
Action printMessage;

void PrintDate()
{
    Console.WriteLine(DateTime.Now);

}


void PrintName()
{
    Console.WriteLine("Henry");
}

printMessage = PrintDate;
printMessage();

printMessage = PrintName;
printMessage();
Console.WriteLine("============");

//passing a function as parametes 
void Process(Action action)
{
    Console.WriteLine("before exec");
    action();
    Console.WriteLine("after exec");
}
Process(PrintDate);
Console.WriteLine();
Process(PrintName);
Console.WriteLine("============");

//void function that receives a parameter
Action<int> alterNumber;

void Add1(int value)
{
    value++;
    Console.WriteLine($"The value is {value}");
}

alterNumber = Add1;
alterNumber(5);
Console.WriteLine("============");
//void function that receives 2 parameters
Action<string, int> printNTimes;
void Print(string message, int times)
{
    for (int i = 0; i < times; i++)
    {
        Console.WriteLine(message);
    }
}

printNTimes = Print;
printNTimes("Alo", 5);
Console.WriteLine("============");

//Func
//functions that return string and receives no parameters
Func<string> returnString;

string GetCurrentDate()
{
    return DateTime.Now.ToString("MM/dd/yyyy");
}

returnString = GetCurrentDate;  
var res = returnString();
Console.WriteLine(res);
Console.WriteLine("============");

void ProcessFunc(Func<string> func)
{
    Console.WriteLine("before exec func");
    var v = func();
    Console.WriteLine(v);
    Console.WriteLine("after exec func");
}

ProcessFunc(GetCurrentDate);
Console.WriteLine("============");

//a func that receives parameters
Func<int, string> receivesIntReturnsString;

string GetNameOfMonth(int month)
{
    var date = new DateTime(2023,month,1);
    return date.ToString("MMMM");
}

receivesIntReturnsString = GetNameOfMonth;

var feb = receivesIntReturnsString(2);
Console.WriteLine(feb);
Console.WriteLine("============");

//Predicate - func that returns a bool
bool IsEven(int n)
{
    return n % 2 == 0;
}

Predicate<int> predicate = IsEven;
var numero = 4;
Console.WriteLine($"Is {numero} even? {predicate(numero)}");

var numero2 = 5;
Console.WriteLine($"Is {numero2} even? {predicate(numero2)}");
Console.WriteLine("============");
//Delagates - A pointer that points to a function

bool TryParse2(string value, out int result)
{
    return int.TryParse(value, out result);
}

//this wont work
//Func<string, int, bool> tryParseFunc = TryParse2;
TryParseDelegate mydel = TryParse2;



int value;
if(mydel("12", out value))
{
    Console.WriteLine(++value);
}
delegate bool TryParseDelegate(string value, out int result);