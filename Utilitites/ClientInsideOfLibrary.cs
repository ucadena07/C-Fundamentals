using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilitites
{
    internal class ClientInsideOfLibrary
    {
        public void Testing()
        {
            var test = new PublicClassForTesting();
            //test.ProtectedProp = 1;
            test.ProtectedInternalProp = 2;
        }
    }
}
