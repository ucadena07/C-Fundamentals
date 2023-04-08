using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP;

internal class AWSFileStorage : IFileStorage
{
    public string Save(string file)
    {
        Console.WriteLine("Saving file in aws");
        return "Aws's file url";
    }
    public void Delete(string file)
    {
        Console.WriteLine("deleting file in aws");
    }

}
