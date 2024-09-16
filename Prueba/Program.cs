//Random numbers and get the max number:
using System.Numerics;


Random random = new Random();

int discountPercentage = 0;
var continua = true;

// Your code goes here

while (continua)
{
    int daysUntilExpiration = random.Next(12);
    Console.Clear();
    Console.WriteLine("Total de dias hasat que expire segun random:" + daysUntilExpiration);


    if (daysUntilExpiration == 0)
    {
        
        Console.WriteLine("Your subscription has expired.");


    }
    else
    {

        if (daysUntilExpiration <= 1)
        {
            Console.WriteLine("Your subscription expires within a day! Renew now and save 20%!");


        }
        else
        {
            if (daysUntilExpiration <= 5)
            {
                Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days. Renew now and save 10%!");
            }
            else
            {

                if (daysUntilExpiration <= 10)
                {
                    Console.WriteLine("Your subscription will expire soon. Renew now!");
                };

            }

        }

    }
    var tecla = Console.ReadKey();
    if (tecla.KeyChar == 'x')
    { continua = false; }



}
