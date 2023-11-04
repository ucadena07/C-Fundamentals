using IntroToLINQ;

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
        IsSingle = true },
    new Person {
        Name = "Nidia",
        Age = 19,
        HiredDate = new DateTime(2015, 11, 22),
        IsSingle = true },
    new Person {
        Name = "Alejandro",
        Age = 45,
        HiredDate = new DateTime(2020, 4, 12),
        IsSingle = false },
    new Person {
        Name = "Valentina",
        Age = 24,
        HiredDate = new DateTime(2021, 7, 8),
        IsSingle = false },
    new Person {
        Name = "Roberto",
        Age = 61,
        HiredDate = DateTime.Now.AddDays(-1),
        IsSingle = false },
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