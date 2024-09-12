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



int fahrenheit= 94;


Console.WriteLine( "The temperature is: " +  Math.Round( (fahrenheit-32) * ((decimal)5/9),1)  + " Celsius" );


//// project Overview: students and qualifications.
///



decimal Sofia_1, Sofia_2,Sofia_3,Sofia_4,Sofia_5;
decimal Nicolas_1, Nicolas_2,Nicolas_3,Nicolas_4,Nicolas_5;
decimal Zahirah_1, Zahirah_2,Zahirah_3,Zahirah_4,Zahirah_5;
decimal Jeong_1, Jeong_2,Jeong_3,Jeong_4,Jeong_5;

decimal Sofia_prom, Nicolas_prom, Zahirah_prom, Jeong_prom;

Sofia_1=93m;
Sofia_2=87m;
Sofia_3=98m;
Sofia_4=95m;
Sofia_5=100m;
Nicolas_1=80m;
Nicolas_2=83m;
Nicolas_3=82m;
Nicolas_4=88m;
Nicolas_5=85m;
Zahirah_1=84m;
Zahirah_2=96m;
Zahirah_3=73m;
Zahirah_4=85m;
Zahirah_5=79m;
Jeong_1=90m;
Jeong_2=92m;
Jeong_3=98m;
Jeong_4=100m;
Jeong_5=97m;

//int[ ] numeros = {93, 87, 98, 95,100};


Sofia_prom= (Sofia_1+Sofia_2 + Sofia_3+ Sofia_4 + Sofia_5)/5;
Nicolas_prom= (Nicolas_1+ Nicolas_2+Nicolas_3+Nicolas_4+Nicolas_5)/5;
Zahirah_prom=(Zahirah_1+ Zahirah_2+Zahirah_3+Zahirah_4+Zahirah_5)/5;
Jeong_prom= (Jeong_1+ Jeong_2+Jeong_3+Jeong_4+Jeong_5);



Console.WriteLine("La nota de Sohia es: " + Sofia_prom);
Console.WriteLine("La nota de Nicolas es: " + Nicolas_prom);
Console.WriteLine("La nota de Zahirah es: " + Zahirah_prom);
Console.WriteLine("La nota de Jeong es: " + Jeong_prom);



























