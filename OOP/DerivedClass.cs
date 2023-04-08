using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilitites;

namespace OOP;

internal class DerivedClass : PublicClassForTesting
{
    void Method()
    {
        ProtectedProp = 1;
        ProtectedInternalProp = 2;
    }
}
