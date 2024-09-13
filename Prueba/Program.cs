//Random numbers and get the max number:
using System.Numerics;

Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total =0;

List<int> list = new List<int>();
//list.Add(dice.Next(1,7));


for( int i=1; i<=3;i++)
{
   list.Add( dice.Next(1,7));
   total= total + list[i-1];
   Console.WriteLine(list[i-1]);
    
};

Console.WriteLine("El valor total es: "+ total);

//Console.WriteLine($"Dice roll:  + {list[0]} + {list[1]} + {list[2]}  = {total} ");
//Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");


if( ( list[0] == list[1])  ||  ( list[1] == list[2]) || ( list[0] == list[2])   )
{
    Console.WriteLine(" Ypu rolled doubles! += 2 bonus");
    total+=2;

}


if( ( list[0] == list[1])  &&  ( list[1] == list[2])    )
{
    Console.WriteLine(" Ypu rolled doubles! += 6 bonus");
    total+=6;

}


if(total > 14)
{

    Console.WriteLine("You winr");
}
else{
    Console.WriteLine("Sorry you lose");
}

/// Identificar valores duplicados:
/// 

