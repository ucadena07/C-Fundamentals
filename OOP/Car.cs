using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace OOP;


internal abstract  class Vehicle : Pars
{
    public Vehicle()
    {
        
    }
    public Vehicle(string brand)
    {
        Brand = brand;
    }

    public string Brand { get; set; }
    public int Year { get; set; }
    public int Speed { get; private set; }
    public abstract int MaxSpeed { get;  }

    public virtual void GoInReverse()
    {
        Console.WriteLine("Reverse on");
    }

    public abstract void SoundHorn();
}

internal class Car : Vehicle
{
    public Car(string brand) : base(brand)
    {
    }

    public override int MaxSpeed => 140;

    public override void SoundHorn()
    {
        Console.WriteLine("car horn sounding");
    }

    public void TurnOnRadio()
    {
        Console.WriteLine("Turning on the radio");
    }
}

internal class Truck : Vehicle
{

    public override int MaxSpeed => 100;

    public override void SoundHorn()
    {
        Console.WriteLine("truck horn sounding");
    }
    public override void GoInReverse()
    {
        Console.WriteLine("BEEP BEEP BEEP");
    }
}

internal class Pars 
{
    public partial class Parameters
    {
        public int Test { get; set; }
    }
}

//can not be deriaved 
internal sealed class CanNotBeDerivedFrom
{
    
}


