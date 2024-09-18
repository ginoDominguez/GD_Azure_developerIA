

for (int i = 0; i <= 100; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine($"{i}\t FizzBuzz");
    }
    else
        {
            if (i % 3 == 0)
            { Console.WriteLine($"{i}\tFizz"); }
            else if (i % 5 == 0)
            {
                Console.WriteLine($"{i}\tBuzz");

            }
            else {Console.WriteLine($"{i}");}
        }
   
}