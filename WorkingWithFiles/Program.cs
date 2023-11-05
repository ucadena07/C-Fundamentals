var fileLocation = @"C:\Users\ucade_lbz6a\OneDrive\Documents\ASP.NET\Fundamentals\Fundamentals\WorkingWithFiles\exampleLines.txt";
if (File.Exists(fileLocation))
{
    var lines = File.ReadAllLines(@"C:\Users\ucade_lbz6a\OneDrive\Documents\ASP.NET\Fundamentals\Fundamentals\WorkingWithFiles\exampleLines.txt");
    var copyLocation = @"C:\Users\ucade_lbz6a\OneDrive\Documents\ASP.NET\Fundamentals\Fundamentals\WorkingWithFiles\exampleLines_copy.txt";
    File.Copy(fileLocation, copyLocation,overwrite: true);
    //Console.WriteLine(lines);
}

var route = @"C:\Users\ucade_lbz6a\OneDrive\Documents\ASP.NET\Fundamentals\Fundamentals\WorkingWithFiles\MyDir\sub1\sub2";
var sub2 = @"C:\Users\ucade_lbz6a\OneDrive\Documents\ASP.NET\Fundamentals\Fundamentals\WorkingWithFiles\MyDir\sub1\sub2";
Directory.CreateDirectory(route);

var routeToEnumerate = @"C:\Users\ucade_lbz6a\OneDrive\Documents\ASP.NET\Fundamentals\Fundamentals\WorkingWithFiles";
var routes = Directory.EnumerateDirectories(routeToEnumerate,"*",SearchOption.AllDirectories);
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
var sw = 
    new StreamWriter(@"C:\Users\ucade_lbz6a\OneDrive\Documents\ASP.NET\Fundamentals\Fundamentals\WorkingWithFiles\custom.txt", append:true);
sw.WriteLine("Good morning");
sw.Write("In this letter ");
sw.WriteLine($"The time is {DateTime.Now.ToString("hh:mm:sss")}");
sw.WriteLine("bye");
sw.Dispose();