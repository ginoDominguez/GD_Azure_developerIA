// See https://aka.ms/new-console-template for more information

Console.WriteLine("123");
Console.WriteLine(123);

Console.WriteLine("true");
Console.WriteLine(true);


Console.Write(121);



 // Listas para almacenar datos
 List<string> materias = new List<string> { "English 101", "Algebra 101", "Biology 101", "Computer Science I", "Psychology 101" };
 List<int> grade = new List<int> { 4, 3, 3, 3, 4 };
 List<int> creditHours = new List<int> { 3, 3, 4, 4 , 3 };


Console.WriteLine("Student: Sophia Johnson");

// Mostrar cuadro de resultados
        Console.WriteLine("{0,-15} {1,-10} {2,-10}", "Materia", "Nota", "Grado");


// Calcular promedio de as notas

decimal promedio = (decimal)(grade[0] +grade[1]+ grade[2] + grade[3] + grade[4]) / 5;

Console.WriteLine("Course \t" + "Grade \t" + "Credit Hours"  );
Console.WriteLine( materias[0] + "\t" + grade[0] + "\t" + creditHours[0] );
Console.WriteLine( materias[0] + "\t" + grade[1] + "\t" + creditHours[1] );
Console.WriteLine( materias[0] + "\t" + grade[2] + "\t" + creditHours[2] );
Console.WriteLine( materias[0] + "\t" + grade[3] + "\t" + creditHours[3] );
Console.WriteLine( materias[0] + "\t" + grade[4] + "\t" + creditHours[4] );

Console.WriteLine("\n\n"+ "Final GPA: " + promedio);




