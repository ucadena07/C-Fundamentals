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



