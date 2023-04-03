using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesStructsAndRecords
{
    public class Car
    {
        string _brand;
        int _year;

        internal string Brand
        {
            get { return _brand?.ToUpper(); }
            set { _brand = value; }
        }

        internal int Year {get; set;}
        internal int Speed { get; } = 20;
        internal string CommercialName => $"{Brand} {Year}";
    }
}
