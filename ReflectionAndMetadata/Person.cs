using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionAndMetadata;

internal class Person
{
    public string Name { get; set; }
    [Range(minimum:18,maximum:130)]
    public int Age { get; set; }
    [Range(minimum: 0, maximum: 10_000)]
    public int Salary { get; set; }
    public Person()
    {

    }
    public Person(string name)
    {
        Name = name;
    }
}
