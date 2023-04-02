//Simple fuction
string GetName()
{
    return "Ulises";
}

//No return value
void PrintCurrentTime()
{
   // Console.WriteLine(DateTime.Now);
}

GetName();
PrintCurrentTime();

//passing data
double Average(int[] numbers)
{
    var sum = 0.0;
    foreach (var number in numbers)
    {
        sum += number;
    }
    return sum /numbers.Length;
}

Console.WriteLine(Average(new int[] { 1,5,7,2}));

double Average2(params int[] numbers)
{
    var sum = 0.0;
    foreach (var number in numbers)
    {
        sum += number;
    }
    return sum / numbers.Length;
}

Console.WriteLine(Average2(1, 5, 7, 2));