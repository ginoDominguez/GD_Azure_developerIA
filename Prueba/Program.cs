/*int first = 2;
string second = "7";
int result = first + int.Parse(second);
Console.WriteLine(result);
*/

/*string value1 = "5";
string value2 = "7";
int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
Console.WriteLine(result);
*/

//combine string array values as strings and as integers

/*
using System.Linq.Expressions;
using Microsoft.VisualBasic;

string[] values = { "12.3", "45", "ABC", "11", "DEF" };
double resultado=0.0;
string cadena = ""; 

for (int i = 0; i<=(values.Length-1); i++)
{
    if(double.TryParse((values[i].ToString()), out resultado))
    {
        resultado+= resultado ;

    }
    else{
        cadena= cadena + values[i];

    }
}

Console.WriteLine("Message= " + cadena);
Console.WriteLine("Total: " + resultado);

*/


int value1 = 11;
decimal value2 = 6.2m;
float value3 = 4.3f;
decimal result1, result2;
float result3;

// Your code here to set result1
// Hint: You need to round the result to nearest integer (don't just truncate)

result1=value1/value2;

Console.WriteLine($"Divide value1 by value2, display the result as an int: {Math.Round(result1,0)}");

// Your code here to set result2
result2= value2/ (decimal)value3;
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

// Your code here to set result3
result3= value3/value1;
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");