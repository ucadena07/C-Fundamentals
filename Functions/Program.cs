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

//Console.WriteLine(Average(new int[] { 1,5,7,2}));

double Average2(params int[] numbers)
{
    var sum = 0.0;
    foreach (var number in numbers)
    {
        sum += number;
    }
    return sum / numbers.Length;
}


//Console.WriteLine(Average2(1, 5, 7, 2));


//passing a value type
int num1 = 5;

void Double(ref int n)
{
    n *= 2;
    Console.WriteLine($"the value inside is : {n}");
}


//Console.WriteLine($"the value outside is : {num1}");
//Double(ref num1);
//Console.WriteLine($"the value outside is : {num1}");

//passing a ref type

void DoubleArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] *= 2;
    }
}

void PrintArray(int[] numbers)
{
    foreach (var item in numbers)
    {
        Console.WriteLine($"{item}");
    }
}

var oArray = new int[] { 5, 10, 20 };

PrintArray(oArray);
DoubleArray(oArray);
Console.WriteLine("===============");
PrintArray(oArray);
