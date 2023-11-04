﻿using IntroToLINQ;

int[] numbers = Enumerable.Range(1, 20).ToArray(); 

//This is LINQ (Method syntax)
var test = numbers.Where(x => x % 2 == 0).ToList();  


//Form 2: Query syntax
var test2 = (from n in numbers
                    where n % 2 == 0
                    select n).ToList();


// Step1 : Deferred execution
var evenNums = numbers.Where(x => 
{
    //Console.WriteLine($"Evaluating if {x} is even");
    return x % 2 == 0; 
});

foreach (var num in evenNums)
{
    //Console.WriteLine($"Yes, {num} is even");
}
//Console.WriteLine("The END");
//Console.WriteLine("=====================================");
// Step2 : NON-Deferred execution
var evenNums2 = numbers.Where(x =>
{
    //Console.WriteLine($"Evaluating if {x} is even");
    return x % 2 == 0;
}).ToList();

foreach (var num in evenNums2)
{
    //Console.WriteLine($"Yes, {num} is even");
}
//Console.WriteLine("The END");

//==== where func ==============
var odd = numbers.Where(x => x % 2 == 1).ToList();
var evenBiggerThan10 = numbers.Where(x => x % 2 == 0 && x > 10).ToList();


//More complex objects 
var people = new List<Person>() {
    new Person {
        Name = "Eduardo",
        Age = 30,
        HiredDate = new DateTime(2021, 1, 2),
        IsSingle = true,
        PhoneNumbers = new List<string>(){"111-111","222-222"},
    },
    new Person {
        Name = "Nidia",
        Age = 19,
        HiredDate = new DateTime(2015, 11, 22),
        IsSingle = true,
         PhoneNumbers = new List<string>(){"141-511","282-822"},},
    new Person {
        Name = "Alejandro",
        Age = 45,
        HiredDate = new DateTime(2020, 4, 12),
        IsSingle = false,
         PhoneNumbers = new List<string>(){"711-111","222-272"},},
    new Person {
        Name = "Valentina",
        Age = 24,
        HiredDate = new DateTime(2021, 7, 8),
        IsSingle = false,
         PhoneNumbers = new List<string>(){"211-111","422-222"},},
    new Person {
        Name = "Roberto",
        Age = 61,
        HiredDate = DateTime.Now.AddDays(-1),
        IsSingle = false,
         PhoneNumbers = new List<string>(){"111-111","222-222"},},
};

var peopleWithAge25OrLess = people.Where(x => x.Age <= 25).ToList();    
var singlePeople = people.Where(x => x.IsSingle).ToList();    
var singleLessThan25 = people.Where(x => x.IsSingle && x.Age < 25).ToList();
var hireDateLessThan3MonthsAgo = people.Where(x => x.HiredDate >= DateTime.Today.AddMonths(3)).ToList();
//==== FirstOrDefault ==============
var firstPerson = people.First();   
var firstPerson2 = people.FirstOrDefault();   
var firstPerson3 = people.FirstOrDefault(x => x.Age < 25);
//==== Order ==============
var orderedNumbers = numbers.OrderBy(x => x).ToList();  
var orderedNumbers2 = numbers.OrderByDescending(x => x).ToList();  
var peopleOrderByAge = people.OrderBy(x => x.Age).ToList();
//==== Select ==============
var names = people.Select(x => x.Name).ToList();
var namesAndAges = people.Select(x => new {x.Name, x.Age}).ToList();
var dto = people.Select(x => new PersonDTO { Age = x.Age, Name = x.Name}).ToList();

//math operation
var ints = Enumerable.Range(1, 5).ToList();
var intsDouble = ints.Select(x => x*2).ToList();

//using the index
foreach (var item in people.Select((x, index) => new {Name = x.Name, Index = index +1 }))
{
    //Console.WriteLine($"{item.Name} - {item.Index}");
}

//==== Select Many ==============
//var wrongSolution = people.Select(x => x.PhoneNumbers).ToList();    
//example1 : Flatten the phones number in a single collection 
var phoneNumbers= people.SelectMany(x => x.PhoneNumbers).ToList();

//example 2: pairing 2 collections
int[] list1 = { 1, 2, 3 };

var peopleAndNumber = people.SelectMany(p => list1, (p,n) => new {Person = p, Number = n}); 
foreach (var item in peopleAndNumber)
{
    //Console.WriteLine($"{item.Person.Name} - {item.Number}");
}
//example 3: people and phoneNumbers
var peopleAndPhoneNumbers = people.SelectMany(p => p.PhoneNumbers, (person, phoneNumber) => new
{
    Person = person,
    phoneNumber = phoneNumber
});
foreach (var item in peopleAndPhoneNumbers)
{
    Console.WriteLine($"{item.Person.Name} - {item.phoneNumber}");
}