using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP;

internal class AzureFileStorage : IFileStorage
{
    public void Delete(string file)
    {
        Console.WriteLine("deleting file in azure");
    }

    public string Save(string file)
    {
        Console.WriteLine("Saving file in azure");
        return "Azure's file url";
    }
    public string Edit(string fileUrl, string file)
    {
        Console.WriteLine("new implementation");
        return "";
    }
}
