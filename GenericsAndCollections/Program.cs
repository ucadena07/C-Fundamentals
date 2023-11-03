using GenericsAndCollections;

int[] numbers = {1,2,3};
string[] names = { "uli", "haylee", "rico", "nigel" };
DateTime[] dates = {DateTime.Today, DateTime.Today.AddDays(1)};

//numbers = new int[0];
//names = new string[0];
//dates = new DateTime[0];

var utilsInt = new ArrayUtils<int>();
var utilsString = new ArrayUtils<string>();
var utilsDate = new ArrayUtils<DateTime>();

//Console.WriteLine(utilsInt.ComputeLengthOfArray(numbers));
//Console.WriteLine(utilsString.ComputeLengthOfArray(names));
//Console.WriteLine(utilsDate.ComputeLengthOfArray(dates));
//Console.WriteLine("================================");
//Console.WriteLine(utilsInt.FirstElementOrDefault(numbers));	
//Console.WriteLine(utilsString.FirstElementOrDefault(names));	
//Console.WriteLine(utilsDate.FirstElementOrDefault(dates));	

//=================== List  ==========================================================
List<int> numbersList = new List<int>() { 1,2,3,4};
numbersList.Add(5);

foreach (var number in numbersList)
{
    //Console.WriteLine(number);
}
//=================== Dictionaries  ==================================================
Dictionary<string,int> dictionary = new Dictionary<string,int>();
dictionary["One"] = 1;
dictionary["Two"] = 2;
dictionary["Three"] = 3;
//Console.WriteLine(dictionary["Two"]);

//if(dictionary.ContainsKey("Four"))
    //Console.WriteLine(dictionary["Four"]);
//else
    //Console.WriteLine("Key not found");

dictionary.Remove("One");
dictionary.Add("Four", 4);

foreach(var key in dictionary.Keys)
{
    //Console.WriteLine(key);
}
foreach (var value in dictionary.Values)
{
    //Console.WriteLine(value);
}

//Example 2: Classifying numbers
var dictionaryEvenOdd = new Dictionary<string,List<int>>();   
dictionaryEvenOdd.Add("Even",new List<int>());
dictionaryEvenOdd.Add("Odd",new List<int>());

for (int i = 0; i< 10; i++)
{
    var key = i % 2 == 0 ? "Even":"Odd";
    dictionaryEvenOdd[key]  .Add(i);    
} 

foreach (var keyValuePair in dictionaryEvenOdd)
{
    //Console.WriteLine(keyValuePair.Key);
    foreach (var value in keyValuePair.Value)
    {
        //Console.WriteLine(value);
    }
    //Console.WriteLine("==============");
}
//=================== Get Hash Code  ==================================================

string Test = "Ulises";
//Console.WriteLine(Test.GetHashCode());

//=================== Yield  ==================================================

var enumOfNumbers = First3Numbers();
var firstNum = enumOfNumbers.First();
var firstTwo = enumOfNumbers.Take(2);

foreach (var value in firstTwo)
{
    Console.WriteLine(value);
}
Console.WriteLine("END");

IEnumerable<int> First3Numbers()
{
    yield return 1;
    yield return 2;
    yield return 3;
}

