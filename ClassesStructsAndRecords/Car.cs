using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesStructsAndRecords
{
    public class Car
    {
        //constructor
        public Car()
        {
            InstancesCount++;
        }

        //Properties
        string _brand;
        int _year;

        internal string Brand
        {
            get { return _brand?.ToUpper(); }
            set { _brand = value; }
        }

        internal static int InstancesCount { get; set; }    
        internal int Year {get; set;}
        internal int Speed { get; private set; } = 20;
        internal string CommercialName => $"{Brand} {Year}";

        //Functions and methods
        internal void Accelerate()
        {
            if(Speed >= 120)
            {
                Console.WriteLine("Max speed reached");
                return;
            }
            Speed = Speed + 50;
        }

        internal void Stop() => Speed = 0;

    }
}
