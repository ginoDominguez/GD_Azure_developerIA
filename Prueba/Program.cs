/// https://learn.microsoft.com/es-es/training/modules/create-c-sharp-methods-return-values/7-exercise-challenge-dice-game
/// Desafío de minijuego de dados
/// https://learn.microsoft.com/en-us/training/modules/create-c-sharp-methods-return-values/10-summary#completion
/// https://learn.microsoft.com/en-us/training/modules/guided-project-visit-petting-zoo/

using System;

string[] students = new string[] {"Sophia", "Nicolas", "Zahirah", "Jeong"};

int studentCount = students.Length;

try
{
    Console.WriteLine("The final name is: " + students[studentCount-1]);
    }
catch {
    Console.WriteLine("No se pudo");
}