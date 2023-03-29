﻿//Negation
var todayIsSunday = true;
todayIsSunday = !todayIsSunday;


//boolean logic 
var isValid = false;

var num1 = 5;
var num2 = 6;

//greater than
var isNum1EqualToNum2 = num1 ==  num2;
var isNumGreaterThanNum2 = num1 >  num2;


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
if(lastName is not null)
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
