using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace OOP;


internal partial class Vehicle : Pars
{
    public string Brand { get; set; }
    public int Year { get; set; }

    public virtual void GoInReverse()
    {
        Console.WriteLine("Reverse on");
    }

}

internal class Car : Vehicle
{


    public void TurnOnRadio()
    {
        Console.WriteLine("Turning on the radio");
    }
}

internal class Truck : Vehicle
{
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


