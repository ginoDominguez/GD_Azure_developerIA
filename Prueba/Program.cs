string[] students = {"Jenna", "Ayesha", "Carlos", "Viktor"};
Console.Clear();
DisplayStudents(students);
Console.WriteLine();
DisplayStudents(new string[] {"Robert","Vanya"});

void DisplayStudents(string[] students) 
{
    foreach (string student in students) 
    {
        Console.Write($"{student}, ");
    }
    Console.WriteLine();
}