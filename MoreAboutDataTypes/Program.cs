using MoreAboutDataTypes;

var num1 = 5;

if(num1.ToString() == "5")
{

}

var todayIsThursday = true;


var numString = "5";

int num = int.Parse(numString);

num++;

var decimalString = "4.9";
var decimalAmount = decimal.Parse(decimalString);


//booleans

var booleanString = "true";
var b = bool.Parse(booleanString);

var dateString = "2023-02-03";
var date = DateTime.Parse(dateString);

var fakeNumber = "djhfdhf";
int num2;
if (int.TryParse(fakeNumber, out num2))
{
    num2++;
}

var num5 = 7;
var num6 = 8;

//casting explicit - casting it yourself

var divison = (double)num5 / num2;

byte byte1;
int int1 = 3;
byte1 = (byte)int1;


byte byte2 = 7;
int int2;

int2 = byte2;

//enums


var status = SalesStatus.Successful;

var s = 3;

var statusEnum = (SalesStatus)s;
var normalStatus = (int)SalesStatus.Successful;
//ctrl R + ctrl R

switch (status)
{
    case SalesStatus.Successful:
        break;
    case SalesStatus.Pending:
        break;
    case SalesStatus.Failed:
        break;
    default:
        break;
}

char[] vowels = new char[5];
vowels[0] = 'a';
vowels[1] = 'e';
vowels[2] = 'i';
vowels[3] = 'o';
vowels[4] = 'u';


//last Element
Index lastElement = ^1;
var lastVowel = vowels[lastElement];

var last2Elemets = vowels[^2..];

Range igonoredFirstAndLast = 1..^1;

//ranges
Range first2Elems = ..2;
var first2 = vowels[first2Elems]; // 0,1

//2 dimensional arrays
int[,] matrix = new int[2, 2];
matrix[0, 0] = 1; 
matrix[0, 1] = 2; 
matrix[1, 0] = 3; 
matrix[1, 1] = 4;

int[,] matrix2 = new int[,]
{
    { 5,6},
    {7,8}
};

for (int row = 0; row < matrix.GetLength(0); row++)
{
    for (int column = 0; column < matrix.GetLength(1); column++)
    {
        Console.Write(matrix[row,column]);
    }
    Console.WriteLine();
}

//Jagged array 
int[][] jaggedArray =
{
    new int[]{1,2},
    new int[]{1,4,5},
    new int[]{6},
    new int[]{1,5}
};

foreach (var array in jaggedArray)
{
    foreach (var item in array)
    {
        Console.Write(item);
        
    }
    Console.WriteLine(  );
}