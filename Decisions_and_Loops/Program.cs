//Negation
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
Console.WriteLine(isBetween5and10);
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
Console.WriteLine(isLastNameEqualToCadena);