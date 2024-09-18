
bool flag = true;
int value = 10;
if (flag)
{
    
    Console.WriteLine($"Inside the code block: {value}");
}
Console.WriteLine($"Inside the code block: {value}");


string[] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = names.Length - 1; i >= 0; i--)
{
    Console.WriteLine(names[i]);
}

string[] names = { "Alex", "Eddie", "David", "Michael" };
foreach (var name in names)
{
    // Can't do this:
    //if (name == "David") name = "Sammy";
}
