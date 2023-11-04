using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToLINQ;

internal class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public bool IsSingle { get; set; }
    public DateTime HiredDate { get; set; }
    public List<string> PhoneNumbers { get; set; }
    public int CompanyId { get; set; }
}
