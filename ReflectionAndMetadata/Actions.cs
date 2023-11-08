using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionAndMetadata;

internal enum Actions
{
    WriteTXT,
    [Hide(yearBegin:2023,monthBegin:1,dayBegin:1,yearEnd:2023,monthEnd:12,dayEnd:31)]
    WriteXML,
    WriteJSON
}
