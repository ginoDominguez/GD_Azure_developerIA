// https://learn.microsoft.com/es-es/training/modules/write-first-c-sharp-method/3-exercise-create-your-first-method

// Operaciones con metodos



void DisplayRandomNumbers() 
{
    Random random = new Random();
    for (int i = 0; i < 5; i++) 
    {
        Console.Write($"{random.Next(1, 100)} ");
    }
      Console.WriteLine();
}


Console.WriteLine("Generating random numbers:");
DisplayRandomNumbers();





