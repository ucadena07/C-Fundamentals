var fileLocation = @"C:\Users\ucade_lbz6a\OneDrive\Documents\ASP.NET\Fundamentals\Fundamentals\WorkingWithFiles\exampleLines.txt";
if (File.Exists(fileLocation))
{
    var lines = File.ReadAllLines(@"C:\Users\ucade_lbz6a\OneDrive\Documents\ASP.NET\Fundamentals\Fundamentals\WorkingWithFiles\exampleLines.txt");
    var copyLocation = @"C:\Users\ucade_lbz6a\OneDrive\Documents\ASP.NET\Fundamentals\Fundamentals\WorkingWithFiles\exampleLines_copy.txt";
    File.Copy(fileLocation, copyLocation,overwrite: true);
    Console.WriteLine(lines);
}


//var content = File.ReadAllText(@"C:\Users\ucade_lbz6a\OneDrive\Documents\ASP.NET\Fundamentals\Fundamentals\WorkingWithFiles\example.txt");

