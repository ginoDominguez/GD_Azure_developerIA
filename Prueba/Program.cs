/* Caso ejercicio
Supongamos que es un candidato en una entrevista para un puesto de programador. El entrevistador quiere que escriba un programa que compruebe si una dirección IPv4 es válida o no. Se le dan las siguientes reglas:

Una dirección IPv4 válida consta de cuatro números separados por puntos.
Cada número no debe contener ceros iniciales.
Cada número debe oscilar entre 0 y 255.
1.1.1.1 y 255.255.255.255 son ejemplos de direcciones IP válidas.

La dirección IPv4 se proporciona como una cadena. Puede suponer que solo consta de dígitos y puntos (no hay letras en la cadena proporcionada).

¿Cómo abordaría esta tarea?
*/

/*
if ipAddress consists of 4 numbers
and
if each ipAddress number has no leading zeroes
and
if each ipAddress number is in range 0 - 255

then ipAddress is valid

else ipAddress is invalid
*/

string[] ip = {"107.31.1.5", "255.0.0.255", "555..0.555", "255...255"};
string[] address;
bool validLength = false;
bool validZeroes = false;
bool validRange = false;

foreach (string Ip in ip) 
{
    address = Ip.Split(".", StringSplitOptions.RemoveEmptyEntries);

    ValidateLength(); 
    ValidateZeroes(); 
    ValidateRange();

    if (validLength && validZeroes && validRange) 
    {
        Console.WriteLine($"{Ip} is a valid IPv4 address");
    } 
    else 
    {
        Console.WriteLine($"{Ip} is an invalid IPv4 address");
    }
}

void ValidateLength() {
      validLength = address.Length == 4;
}
void ValidateZeroes() {
   
    foreach (string number in address) 
    {
        if (number.Length > 1 && number.StartsWith("0")) 
        {
            validZeroes = false;
        }
    }

    validZeroes = true;
}
void ValidateRange() {
   foreach (string number in address) 
    {
        int value = int.Parse(number);
        if (value < 0 || value > 255) 
        {
            validRange = false;
            return;
        }
    }
    validRange = true;
}