using ClassesStructsAndRecords;

Car car1 = new Car();
car1.Brand = "Audi";
car1.Year = 2017;

var calculator = new Calculator();
var result = Calculator.ComputeDoubleAndTriple(5);

var (value, doubled, tripled) = result;

Car car2 = new Car();
Car car3 = new Car();
Car car4 = new Car();

var message = @"This is a message, 
from: Uli";

//Console.WriteLine(message.CountWords());

string firstName = "Nigel";
if(firstName is { Length: 5 })
{
    //Console.WriteLine("six chars");
}

if (firstName.Length == 5)
{
    //Console.WriteLine("six chars");
}

if(car1 is { Brand:"AUDI" or "LEXUS", Year: > 2015 })
{
    Console.WriteLine("You have a good car");
}else if( car1 is { Year: < 2015 })
{
    Console.WriteLine("Your car is getting old");
}

Console.WriteLine("==============");
var person = new { FirstName = "Henry", LastName = "Cadena", Age = 4 };
var mutatedPerson = person with { Age = 100 };

Console.WriteLine(mutatedPerson);

//=================================
Console.WriteLine("==============");
var pointA = new Point(3, 5);

Console.WriteLine(pointA.X);

Console.WriteLine("==============");
var result2 = Calculator.ComputeDoubleAndTriple(5);
var result3 = Calculator.ComputeDoubleAndTriple(5);
Console.WriteLine($"intances equal: {result2 == result3}");


var pointB = new Point(3, 5);
//Console.WriteLine($"point intances equal: {pointA == pointB}");

Console.WriteLine("==============");

var p1 = new Person() { FirstName = "Nigel", LastName = "Cadena" };
var p2 = new Person() { FirstName = "Nigel", LastName = "Cadena" };
Console.WriteLine($"person intances equal: {p1 == p2}");
Console.WriteLine("==============");

var comp1 = new Company("Udemy", 2011);


var comp2 = comp1 with { year = 2020 };

Console.WriteLine(comp1);
Console.WriteLine(comp2);



ClassWithImmutablesProps imm = new ClassWithImmutablesProps()
{
    MyProperty1 = 1
};

int[] numbers = {1,2};

var length = numbers?.Length ?? 0;

numbers = null;

numbers ??= Array.Empty<int>();

Console.WriteLine(numbers?.Length);

