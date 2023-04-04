using ClassesStructsAndRecords;

Car car1 = new Car();
car1.Brand = "Audi";
car1.Year = 2017;

var calculator = new Calculator();
var result = calculator.ComputeDoubleAndTriple(5);

var (value, doubled, tripled) = result;

Console.WriteLine(doubled);