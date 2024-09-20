/*
string first = "Hello";
string second = "World";
Console.WriteLine("{1} {0}!", first, second);
Console.WriteLine("{0} {0} {0}!", first, second);
*/

/// cambiar el culture Info:
/// 
/*

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

*/






/* output expected:
Dear Ms. Barros,
As a customer of our Magic Yield offering we are excited to tell you about a new financial product that would dramatically increase your return.

Currently, you own 2,975,000.00 shares at a return of 12.75%.

Our new product, Glorious Future offers a return of 13.13%.  Given your current volume, your potential profit would be ¤63,000,000.00.

Here's a quick comparison:

Magic Yield         12.75%   $55,000,000.00      
Glorious Future     13.13%   $63,000,000.00  


*/


string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

// Your logic here
Console.Clear();



Console.WriteLine($"Dear {customerName},");
Console.WriteLine("As a customer of our Magic Yield offering we are excited to tell you about a new financial product that would dramatically increase your return.\n");
Console.WriteLine($"Currently, you own {currentShares:N2} shares at a return of {currentReturn:P2}.\n");
Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P2} 13.13%.  Given your current volume, your potential profit would be ¤{newProfit:C2}.\n");

Console.WriteLine("");

Console.WriteLine("Here's a quick comparison:\n");

string comparisonMessage = "";

// Your logic here
comparisonMessage = currentProduct.PadRight(20,'-');
comparisonMessage += String.Format("{0:P}", currentReturn).PadRight(10);
comparisonMessage += String.Format("{0:C}", currentProfit).PadRight(15);
comparisonMessage += "\n";
comparisonMessage += newProduct.PadRight(20,'-');
comparisonMessage += String.Format("{0:P}", newReturn).PadRight(10);
comparisonMessage += String.Format("{0:C}", newProfit).PadRight(15);

Console.WriteLine(comparisonMessage);

//comparisonMessage =     currentProduct + Magic Yield        string.Format( currentReturn)    {currentProfit:C2}$55,000,000.00 \n";
//comparisonMessage = "${newProduct} Glorious Future         {newReturn:P2}12.75%   {newProfit:C2}$63,000,000.00 \n";






