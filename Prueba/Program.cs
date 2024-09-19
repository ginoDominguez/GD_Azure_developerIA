using System.Runtime.CompilerServices;

int[] pallets = { 1, 2, 3, 4 };

Console.WriteLine("Sorted...");

Array.Sort(pallets);
Array.Clear(pallets, 0, 2);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}



/////Discover Split() and Join()
///
string value = "abc123";
string value3="";
char[] valueArray = value.ToCharArray();


Array.Reverse(valueArray);

value3 = new string(valueArray);

Console.WriteLine(value3);

