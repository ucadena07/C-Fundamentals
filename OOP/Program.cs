using OOP;

Car car = new Car();
car.Brand = "Audi";
car.Year = 2017;

Truck car2 = new Truck();
car2.Brand = "Buick";
car2.Year = 2010;

void ReadBrand(Vehicle vehicle)
{
    var message = $"Reading the brand {vehicle.Brand} of the vehicle type {vehicle}";
    Console.WriteLine(message);
}


car.TurnOnRadio();
ReadBrand(car);
ReadBrand(car2);
car.GoInReverse();
car2.GoInReverse();

