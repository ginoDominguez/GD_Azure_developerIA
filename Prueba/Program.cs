
///https://learn.microsoft.com/en-us/training/modules/csharp-modify-content/
///https://learn.microsoft.com/es-es/training/modules/create-c-sharp-methods-parameters/6-exercise-challenge-email-addresses
///

string[,] corporate = 
{
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
};

string[,] external = 
{
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};

string externalDomain = "hayworth.com";

for (int i = 0; i < corporate.GetLength(0); i++) 
{
    DisplayEmail(first: corporate[i,0], lastname: corporate[i,1]);

}

for (int i = 0; i < external.GetLength(0); i++) 
{
    DisplayEmail(first: external[i,0], lastname: external[i,1], domain: externalDomain);
}



void DisplayEmail(string first, string lastname, string domain="contoso.com")
{
    string email= first.Substring(0, 2) + lastname;
    email = email.ToLower();
    Console.WriteLine(email + domain);

}




