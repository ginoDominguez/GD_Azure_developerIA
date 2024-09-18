//Role playing game battle challenge
/*
int lifeHeroe=10;
int lifeMonster=10;
int attack=0;
Random dice= new Random();


do
{
    attack= dice.Next(1, 10);
    // attack from the heroe 
    lifeMonster= lifeMonster-attack;
    
    Console.WriteLine("Heroe attack:"+attack + " Monster remaining life:" + lifeMonster);

    if (lifeMonster>0)
    {
         attack= dice.Next(1, 10);
         lifeHeroe= lifeHeroe-attack;
         Console.WriteLine("Monster attack:"+attack + " Heroe remaining life:" + lifeHeroe);

    }
}
while(lifeHeroe>0 && lifeMonster>0);

Console.WriteLine($"Heroes end with {lifeHeroe} and Monster end with {lifeMonster}");

if(lifeHeroe>lifeMonster)
{
    Console.WriteLine("Heroe wins");
}
else
{
    Console.WriteLine("Monster wins");
}
Console.ReadKey();

*/

//string? readResult;
/*
string readResult=null;
Console.WriteLine("Enter a string:");
do
{
    readResult = Console.ReadLine();
} while (readResult == null);
*/

string? readResult;
bool validEntry = false;
Console.WriteLine("Enter a string containing at least three characters:");
do
{
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        if (readResult.Length >= 3)
        {
            validEntry = true;
        }
        else
        {
            Console.WriteLine("Your input is invalid, please try again.");
        }
    }
} while (validEntry == false);

/*
// capture user input in a string variable named readResult
int numericValue = 0;
bool validNumber = false;

validNumber = int.TryParse(readResult, out numericValue);
*/

string? readResult_1;
bool validNumber = false;
int numeric_value = 0;




do
{
    Console.WriteLine("Ingrese un valor de 5 a 10");
    readResult_1 = Console.ReadLine();

    validNumber = int.TryParse(readResult_1, out numeric_value);

    if (validNumber == true)
    {
        if( numeric_value >=5 && numeric_value<=10)
        {
            Console.WriteLine("El numero ingresado es de : " + numeric_value + "");


        }
        else
        {
            Console.WriteLine("Enter a number from 5 to 10");
            validNumber=false;
        }
    }


}
while (validNumber==false);




