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

Console.WriteLine(utilsInt.ComputeLengthOfArray(numbers));
Console.WriteLine(utilsString.ComputeLengthOfArray(names));
Console.WriteLine(utilsDate.ComputeLengthOfArray(dates));
Console.WriteLine("================================");
Console.WriteLine(utilsInt.FirstElementOrDefault(numbers));	
Console.WriteLine(utilsString.FirstElementOrDefault(names));	
Console.WriteLine(utilsDate.FirstElementOrDefault(dates));	

