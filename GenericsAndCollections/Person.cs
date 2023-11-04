using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAndCollections;

public class Person : IComparable<Person>   
{
    public string Name { get; set; }
    public int Age { get; set; }

    public int CompareTo(Person other)
    {
        //Explanation: If the value is < 0, then the person goes first
        // If the value is > 0, then the person goes second
        // If the value is 0, then they have the same order

        return Age - other?.Age ?? 0 ; 
    }
}

public class ComparerOfPersonByName : IComparer<Person>
{
    private readonly StringComparison _stringComparison;

    public ComparerOfPersonByName(StringComparison stringComparison = StringComparison.OrdinalIgnoreCase)
    {
        _stringComparison = stringComparison;
    }

    public int Compare(Person x, Person y)
    {
        if(x is null || x.Name is null)
        {
            throw new ArgumentNullException(nameof(x)); 
        }
        if (y is null || y.Name is null)
        {
            throw new ArgumentNullException(nameof(y));
        }
        return string.Compare(x.Name, y.Name, _stringComparison);   
    }
}

