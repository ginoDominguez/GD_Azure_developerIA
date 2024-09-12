// See https://aka.ms/new-console-template for more information
using System.Text;


Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ...\n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");
Console.Write(@"c:\invoices");

// To generate Japanese invoices:
// Nihon no seikyū-sho o seisei suru ni wa:
Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
// User command to run an application
Console.WriteLine(@"c:\invoices\app.exe -j");


int version=11;
string updateText="Update to Windows";
string message= $"{updateText} {version}";

Console.Write(message);


string projectName = "First-Project";
Console.WriteLine(@$"C:\Output\{projectName}\Data");

Console.OutputEncoding = Encoding.UTF8;
projectName = "ACME";

string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";

Console.WriteLine("View English output: \n" + @"c:\Exercise\{projectName}\data.txt" + "\n");


Console.Write( $"{russianMessage}" + "\n" + @"c:\Exercise\ACME\ru-RU\data.txt" );


string firstName="Bob";
int widgetsSold=7;

Console.WriteLine(firstName + " sold" + widgetsSold + " widgets. ");

Console.WriteLine(firstName + " sold" + widgetsSold + 7 + " widgets. ");

Console.WriteLine(firstName + " sold" + widgetsSold + 7 + " widgets. ");



int num1, num2;
int suma, resta, multiplicacion;
decimal division, modulo;


num1= 12;
num2= 7;

suma= num1+ num2;
resta= num1-num2;
multiplicacion= num1 * num2;

Console.WriteLine("suma="+ suma);
Console.WriteLine("resta="+ resta);
Console.WriteLine("Multiplicacion="+ multiplicacion);

decimal.Parse(num1.ToString());

if( num2>0) 
{
    
    division= decimal.Parse(num1.ToString()) / decimal.Parse(num2.ToString());
    Console.WriteLine("Division=" + division);
}
else Console.WriteLine("Num2 debe ser mayor a 0");

modulo= num1 % num2;
Console.WriteLine("Modulo =" + modulo);




// utilice operadores compuestos para realziar operaciones:

// 1.- escribir codigo para incementar o disminur valor:

int  value=1;

value++;

Console.WriteLine( $"valor : {value}");













