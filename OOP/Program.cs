using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OOP;
using System.Diagnostics;
using System.Runtime.Serialization.Formatters;
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

Console.WriteLine("=============================");
var a = new ClassA();
var b = new ClassB();   

void Process(IMySecondInterface mySecond)
{
    mySecond.MethodFromSecondInterface();
}


Process(a);
Process(b);

Console.WriteLine("=============================");
var azureStorage = new AzureFileStorage();
var awsStorage = new AWSFileStorage();

var movieController = new MoviesController(azureStorage);


movieController.SavePoster("image.png");
movieController.DeletePoster("image.png");
Console.WriteLine("=============================");

var hostBuilder = Host.CreateDefaultBuilder(args);
hostBuilder = hostBuilder.ConfigureServices(CustomConfigureServices);
using var host = hostBuilder.Build();

var movieControler = host.Services.GetRequiredService<MoviesController>();
movieControler.SavePoster("image.png");
movieControler.DeletePoster("image.png");

Console.WriteLine("============================= default");
var fs = host.Services.GetRequiredService<IFileStorage>();
fs.Edit("", "");

Console.WriteLine("============================= default");
var v1 = new Vector2D {X = 1, Y = 2};
var v2 = new Vector2D { X = 3, Y = 4};
var v3 = v1 + v2;
Console.WriteLine(v3.ToString());

void CustomConfigureServices(IServiceCollection services)
{
    services.AddTransient<IFileStorage, AzureFileStorage>();
    services.AddTransient<MoviesController>();
}