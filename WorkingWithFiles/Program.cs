using System.Text;
using WorkingWithFiles;
using System.Text.Json;

var fileLocation = @"C:\Users\ucade_lbz6a\OneDrive\Documents\ASP.NET\Fundamentals\Fundamentals\WorkingWithFiles\exampleLines.txt";
if (File.Exists(fileLocation))
{
    var lines = File.ReadAllLines(@"C:\Users\ucade_lbz6a\OneDrive\Documents\ASP.NET\Fundamentals\Fundamentals\WorkingWithFiles\exampleLines.txt");
    var copyLocation = @"C:\Users\ucade_lbz6a\OneDrive\Documents\ASP.NET\Fundamentals\Fundamentals\WorkingWithFiles\exampleLines_copy.txt";
    File.Copy(fileLocation, copyLocation, overwrite: true);
    //Console.WriteLine(lines);
}

var route = @"C:\Users\ucade_lbz6a\OneDrive\Documents\ASP.NET\Fundamentals\Fundamentals\WorkingWithFiles\MyDir\sub1\sub2";
var sub2 = @"C:\Users\ucade_lbz6a\OneDrive\Documents\ASP.NET\Fundamentals\Fundamentals\WorkingWithFiles\MyDir\sub1\sub2";
Directory.CreateDirectory(route);

var routeToEnumerate = @"C:\Users\ucade_lbz6a\OneDrive\Documents\ASP.NET\Fundamentals\Fundamentals\WorkingWithFiles";
var routes = Directory.EnumerateDirectories(routeToEnumerate, "*", SearchOption.AllDirectories);
foreach (var routePath in routes)
{
    //Console.WriteLine(routePath);
}

var files = Directory.EnumerateFiles(routeToEnumerate, "*.json", SearchOption.AllDirectories);
foreach (var file in files)
{
    //Console.WriteLine(file);
}
Directory.Delete(sub2);

foreach (var file in files)
{
    //Console.WriteLine(Path.GetFileName(file) + $" ext: {Path.GetExtension(file)}");
}

//var content = File.ReadAllText(@"C:\Users\ucade_lbz6a\OneDrive\Documents\ASP.NET\Fundamentals\Fundamentals\WorkingWithFiles\example.txt");

//============= Streams ==============================
//good for big methods 
using (var sw =
    new StreamWriter(@"C:\Users\ucade_lbz6a\OneDrive\Documents\ASP.NET\Fundamentals\Fundamentals\WorkingWithFiles\custom.txt", append: true))
{
    sw.WriteLine("Good morning");
    sw.Write("In this letter ");
    sw.WriteLine($"The time is {DateTime.Now.ToString("hh:mm:sss")}");
    sw.WriteLine("bye");
}


//good for small methods 
void UseSW()
{
    using var sw = new StreamWriter(@"C:\Users\ucade_lbz6a\OneDrive\Documents\ASP.NET\Fundamentals\Fundamentals\WorkingWithFiles\custom.txt", append: true);
    sw.WriteLine("Good morning");
    sw.Write("In this letter ");
    sw.WriteLine($"The time is {DateTime.Now.ToString("hh:mm:sss")}");
    sw.WriteLine("bye");

}

var dest = @"C:\Users\ucade_lbz6a\OneDrive\Documents\ASP.NET\Fundamentals\Fundamentals\WorkingWithFiles\people.txt";
var people = new List<Person>()
{
    new() { Id = 1, Name="Henry", Salary=25},
    new() { Id = 2, Name="Nigel", Salary=30},
    new() { Id = 3, Name="Alo", Salary=40},
    new() { Id = 4, Name="Uli", Salary=45},
    new() { Id = 5, Name="Haylee", Salary=50},
};
var stringBuilder = new StringBuilder();    
foreach (var person in people)
{                           
    stringBuilder.AppendLine($"{person.Id.ToString().PadLeft(10,'0')}|{person.Name.PadLeft(30)}|{person.Salary.ToString().PadLeft(10,'0')}");  
}
using (var sw = new StreamWriter(dest, append: false))
{
    sw.Write(stringBuilder.ToString());
}

//=============== CSV ================================== 
var stringBuilderForCsv = new StringBuilder();
var destCSV = @"C:\Users\ucade_lbz6a\OneDrive\Documents\ASP.NET\Fundamentals\Fundamentals\WorkingWithFiles\people.csv";
foreach (var person in people)
{
    stringBuilderForCsv.AppendLine($"{person.Id},{person.Name},{person.Salary}");
}
using (var sw = new StreamWriter(destCSV, append: false,  Encoding.UTF8))
{
    sw.Write(stringBuilderForCsv.ToString());
}
//=============== Stream reader ================================== 

using(var sr = new StreamReader(destCSV))
{
    var line = sr.ReadLine();
    while(line != null)
    {
        //Console.WriteLine(line);
        line = sr.ReadLine();
    }
}

//=============== JSON ================================== 
var destJson = @"C:\Users\ucade_lbz6a\OneDrive\Documents\ASP.NET\Fundamentals\Fundamentals\WorkingWithFiles\people.json";

var p1 = people.FirstOrDefault();
var json = JsonSerializer.Serialize(p1);
using(var sw = new StreamWriter(destJson, append: false))
{
    sw.Write(json);
}

var fileContent = File.ReadAllText(destJson);
var desirializedPerson = JsonSerializer.Deserialize<Person>(fileContent);
Console.WriteLine("The end ");