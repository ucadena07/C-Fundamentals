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
Console.WriteLine(message.CountWords());

