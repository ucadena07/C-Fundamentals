using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Base1
    {
        public int Base1Property { get; set; }
    }
    internal class Base2 : Base1
    {
        public int Base2Property { get; set; }
    }
    internal class Derived: Base2
    {
        public int DerivedProperty { get; set; }

        void Method()
        {
           Base1Property = 1;
           Base2Property = 2;
        }
    }

    internal class SubDerived: Derived
    {

    }
}
