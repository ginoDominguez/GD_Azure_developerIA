using System.Runtime.ConstrainedExecution;

string pangram = "The quick brown fox jumps over the lazy dog";
string[] resultado= pangram.Split(" ");
string output=string.Empty;


for(int i=0; i <= (resultado.Length-1); i++)
{
    /*
   Array.Reverse(resultado);
   output= new string(resultado[i]);
    Console.WriteLine(resultado[i]);
    */
    output+= string.Join("", resultado[i].ToCharArray().Reverse()) +" ";
}
Console.WriteLine(output);


//https://learn.microsoft.com/en-us/training/modules/csharp-arrays-operations/5-challenge-1