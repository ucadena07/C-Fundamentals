using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace OOP;

internal record Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

internal record Teacher: Person
{
    public string[] Subjects { get; set; }
}
