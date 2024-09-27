string status = "Healthy";

Console.WriteLine($"Start: {status}");
SetHealth( false);
Console.WriteLine($"End: {status}");

status="Malo";
Console.WriteLine($"End2: {status}");


void SetHealth(bool isHealthy) 
{
    status = (isHealthy ? "Healthy" : "Unhealthy");
    Console.WriteLine($"Middle: {status}");
}