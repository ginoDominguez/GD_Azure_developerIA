namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
//Console.WriteLine("What is your name?");
        //var name = Console.ReadLine();
        var calculadora = new Calculadora();
     
        Console.WriteLine(calculadora.Suma(2,2));
         Console.WriteLine(calculadora.Resta(2,2));

       
    }
}

