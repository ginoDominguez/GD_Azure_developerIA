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

