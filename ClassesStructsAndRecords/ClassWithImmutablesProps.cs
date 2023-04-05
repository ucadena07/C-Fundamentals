using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesStructsAndRecords
{
    internal class ClassWithImmutablesProps
    {
        [SetsRequiredMembers]
        public ClassWithImmutablesProps()
        {
            MyProperty2 = 1;
        }
        public int MyProperty1 { get; init; }
        public required int MyProperty2 { get; init; }
    }
}
