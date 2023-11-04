int[] numbers = {1,2,3,4,5,6,7};    

//This is LINQ (Method syntax)
var evenNumbers = numbers.Where(x => x % 2 == 0).ToList();  


//Form 2: Query syntax
var evenNumbers2 = (from n in numbers
                    where n % 2 == 0
                    select n).ToList();


