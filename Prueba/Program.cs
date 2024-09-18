//Role playing game battle challenge

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



