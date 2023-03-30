//Negation
var todayIsSunday = true;
todayIsSunday = !todayIsSunday;


//boolean logic 
var isValid = false;

var num1 = 5;
var num2 = 6;

//greater than
var isNum1EqualToNum2 = num1 == num2;
var isNumGreaterThanNum2 = num1 > num2;


//coditional boolean operators
var isBetween5and10 = num1 > 4 && num2 < 10;
//Console.WriteLine(isBetween5and10);
/* The && operator
 * true && true => true
 * true && false => false
 * false && true => false
 * false && false => false
*/

/* The || operator
 * true && true => true
 * true && false => true
 * false && true => true
 * false && false => false
*/

string lastName = null;
var isLastNameEqualToCadena = lastName != null && lastName.ToUpper().Equals("CADENA");
//Console.WriteLine(isLastNameEqualToCadena);

//ternary conditional operator
bool userLoggedIn = true;
string message = userLoggedIn ? "Welcome back" : "Login to start";
//Console.WriteLine(message);

//switch 
var place = 2;
switch (place)
{
    case 1:
        Console.WriteLine("place is equal to 1");
        break;
    case 2:
        Console.WriteLine("place is equal to 2");
        break;
    case 3:
        Console.WriteLine("place is equal to 3");
        break;
    default:
        break;
}

//switch expressions
var msg = place switch
{
    1 => "you got first place",
    2 => "second place",
    3 => "third place",
    4 or 5 => "you almost got it",
    _ => "none of the above"
};

var temp = 36;

var tmpMsg = temp switch
{
    37 => "Healthy",
    > 37 => "FEVER",
    < 35 => "LOW",
    _ => ""
};

//logical patterns
lastName = "meyer";
if (lastName is not null)
{
    //do something
}

tmpMsg = temp switch
{
    37 => "Healthy",
    > 37 and < 39 => "FEVER",
    >= 39 and < 43 => "DOCTOR",
    _ => ""
};

var season = DateTime.Today.Month switch
{
    3 or 4 or 5 => "Spring",
    6 or 7 or 8 => "Summer",
    9 or 10 or 11 => "Fall",
    12 or 1 or 2 => "Winter",
    _ => ""
};

//loops

int counter = 11;
while (counter <= 10)
{
    //Console.WriteLine(counter);
    counter++;
}

int counter2 = 11;
do
{
    //Console.WriteLine(counter2);
    counter2++;
} while (counter2 <= 10);

for (int i = 1; i <= 10; i++)
{
    //Console.WriteLine(i);
}

var name = "Henry";
foreach (var letter in name)
{
    //Console.WriteLine(letter);
}

//break and continue
for (int i = 1; i <= 10; i++)
{
    if(i == 5)
    {
        break;
    }
    //Console.WriteLine(i);

}

for (int i = 1; i <= 10; i++)
{
    if (i == 5)
    {
        continue;
    }
    //Console.WriteLine(i);

}

//infite looops
//while (true)
//{
//    Console.WriteLine("I run forever");
//    if(DateTime.Now.Second == 30)
//    {
//        break;
//    }
//}

//for(; ; )
//{
//    Console.WriteLine("I run forever");
//    if (DateTime.Now.Second == 30)
//    {
//        break;
//    }
//}

while (true)
{
    Console.WriteLine("Welcome to the sum calculator in C#!");
    Console.Write("Write the first number: ");
    var userInput = Console.ReadLine();

    if(userInput == null)
    {
        Console.WriteLine("Error. Try again");
        continue;
    }
    var num10 = int.Parse(userInput);

    Console.Write("Write the second number: ");
    userInput = Console.ReadLine();
    if (userInput == null)
    {
        Console.WriteLine("Error. Try again");
        continue;
    }
    var num11 = int.Parse(userInput);

    Console.WriteLine($"The result of adding {num10} and {num11} is {num10 + num11}");
}