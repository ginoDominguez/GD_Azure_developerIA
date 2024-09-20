/*
string first = "Hello";
string second = "World";
Console.WriteLine("{1} {0}!", first, second);
Console.WriteLine("{0} {0} {0}!", first, second);
*/

/// cambiar el culture Info:
/// 


using System.Globalization;

CultureInfo.CurrentCulture = new CultureInfo("en-US"); //en-US    es-EU

decimal price = 123.45m;
int discount = 50;
Console.WriteLine($"Price: {price:C} (Save {discount:C})");


decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N} units");


decimal measurement2 = 123456.78912m;
Console.WriteLine($"Measurement: {measurement2:N4} units");

decimal tax = .36785m;
Console.WriteLine($"Tax rate: {tax:P}");


decimal price2 = 67.55m;
decimal salePrice = 59.99m;

string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price2 - salePrice), price2);

Console.WriteLine(yourDiscount);



string input = "Pad this";
 Console.WriteLine(input.PadLeft(12));
  Console.WriteLine(input.PadLeft(12,'-'));