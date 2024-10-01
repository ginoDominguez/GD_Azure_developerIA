<<<<<<< HEAD
﻿
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
=======
﻿string[] guestList = { "Rebecca", "Nadia", "Noor", "Jonte" };
string[] rsvps = new string[10];
int count = 0;
>>>>>>> b061fb90a3e0c40e9b82190c2a360e90620b9c7a

}

RSVP("Rebecca", 1, "none", true);
RSVP("Nadia", 2, "Nuts", true);
RSVP("Linh", 2, "none", false);
RSVP("Tony", 1, "Jackfruit", false);
RSVP("Noor", 4, "none", false);
RSVP("Jonte", 2, "Stone fruit", false);
ShowRSVPs();


void RSVP(string name, int partySize = 1, string allergies = "none", bool inviteOnly = true)
//void RSVP(string name, int partySize, string allergies, bool inviteOnly)
{
  if (inviteOnly)
  {
    bool found = false;
    foreach (string guest in guestList)
    {
      if (guest.Equals(name))
      {
        found = true;
        break;
      }
    }
    if (!found)
    {
      Console.WriteLine($"Sorry, {name} is not on the guest list");
      return;
    }
  }
  rsvps[count] = $"Name: {name}, \tParty Size: {partySize}, \tAllergies: {allergies}";
  count++;
}

void ShowRSVPs()
{
  Console.WriteLine("\nTotal RSVPs:");
  for (int i = 0; i < count; i++)
  {
    Console.WriteLine(rsvps[i]);
  }
}