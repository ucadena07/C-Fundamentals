using OOP;
using Utilitites;

Car car = new Car("Audi");

car.Year = 2017;

Truck truck = new Truck();
truck.Brand = "Buick";
truck.Year = 2010;

void ReadBrand(Vehicle vehicle)
{
    var message = $"Reading the brand {vehicle.Brand} of the vehicle type {vehicle}";
    Console.WriteLine(message);
}


car.TurnOnRadio();
ReadBrand(car);
ReadBrand(truck);
car.GoInReverse();
truck.GoInReverse();
car.SoundHorn();
truck.SoundHorn();
Console.WriteLine("=============================");



void acceptAnyParameter(object obj)
{
    //var car = obj as Car; 
    if(obj is Car car)
    {
        car.SoundHorn();
    }
}
acceptAnyParameter(car);
acceptAnyParameter(truck);
Console.WriteLine("=============================");

var publicClassForTesting = new PublicClassForTesting();

publicClassForTesting.PublicMethod();



