using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ClassesStructsAndRecords;


/*
 * Makes compering object easier 
 * Syntatic sugar
 * tranforms into classes or structs when compile
 * inmmutable types
 * can mutate them with 
      var person = new { FirstName = "Henry", LastName = "Cadena", Age = 4 };
      var mutatedPerson = person with { Age = 100 };
   
 * 
 */

//Nominal record
internal record Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

//Positional record
internal record Company(string name, int year);

