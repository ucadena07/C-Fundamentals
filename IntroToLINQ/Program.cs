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
    Console.WriteLine($"Evaluating if {x} is even");
    return x % 2 == 0; 
});

foreach (var num in evenNums)
{
    Console.WriteLine($"Yes, {num} is even");
}
Console.WriteLine("The END");
Console.WriteLine("=====================================");
// Step2 : NON-Deferred execution
var evenNums2 = numbers.Where(x =>
{
    Console.WriteLine($"Evaluating if {x} is even");
    return x % 2 == 0;
}).ToList();

foreach (var num in evenNums2)
{
    Console.WriteLine($"Yes, {num} is even");
}
Console.WriteLine("The END");