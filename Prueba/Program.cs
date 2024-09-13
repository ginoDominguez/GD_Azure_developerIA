//Desafio: implemente un método de la clase Math que devuelva el mayor de dos números.

Random numeroAleatorio = new Random();

int numero1, numero2;

numero1= numeroAleatorio.Next();
numero2= numeroAleatorio.Next();

Console.WriteLine(numero1);
Console.WriteLine(numero2);

Console.WriteLine(System.Math.MaxMagnitude(numero1, numero2));



