using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilitites;

namespace OOP;

internal interface IFileStorage
{
    string Save(string file);
    void Delete(string file);
    string Edit(string fileUrl, string file)
    {
        Delete(fileUrl);
        return Save(file);
    }
}
