<<<<<<< HEAD
﻿//// project Overview: students and qualifications.
///


//https://learn.microsoft.com/en-us/training/modules/challenge-project-arrays-iteration-selection/2-prepare


int[] Sofia = new int[] ;




decimal Sofia_1, Sofia_2,Sofia_3,Sofia_4,Sofia_5;
decimal Nicolas_1, Nicolas_2,Nicolas_3,Nicolas_4,Nicolas_5;
decimal Zahirah_1, Zahirah_2,Zahirah_3,Zahirah_4,Zahirah_5;
decimal Jeong_1, Jeong_2,Jeong_3,Jeong_4,Jeong_5;

decimal Sofia_prom, Nicolas_prom, Zahirah_prom, Jeong_prom;

Sofia_1=93m;
Sofia_2=87m;
Sofia_3=98m;
Sofia_4=95m;
Sofia_5=100m;
Nicolas_1=80m;
Nicolas_2=83m;
Nicolas_3=82m;
Nicolas_4=88m;
Nicolas_5=85m;
Zahirah_1=84m;
Zahirah_2=96m;
Zahirah_3=73m;
Zahirah_4=85m;
Zahirah_5=79m;
Jeong_1=90m;
Jeong_2=92m;
Jeong_3=98m;
Jeong_4=100m;
Jeong_5=97m;

//int[ ] numeros = {93, 87, 98, 95,100};


Sofia_prom= (Sofia_1+Sofia_2 + Sofia_3+ Sofia_4 + Sofia_5)/5;
Nicolas_prom= (Nicolas_1+ Nicolas_2+Nicolas_3+Nicolas_4+Nicolas_5)/5;
Zahirah_prom=(Zahirah_1+ Zahirah_2+Zahirah_3+Zahirah_4+Zahirah_5)/5;
Jeong_prom= (Jeong_1+ Jeong_2+Jeong_3+Jeong_4+Jeong_5);



Console.WriteLine("La nota de Sohia es: " + Sofia_prom);
Console.WriteLine("La nota de Nicolas es: " + Nicolas_prom);
Console.WriteLine("La nota de Zahirah es: " + Zahirah_prom);
Console.WriteLine("La nota de Jeong es: " + Jeong_prom);

=======
﻿/// Program to calculate grades using  arryas
/// 
using System;
using Microsoft.VisualBasic;

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };
int[] beckyScores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
int[] ericScores = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
int[] gregorScores = new int[] { 91, 91, 91, 91, 91, 91, 91 };


string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" , "Becky","Chris","Eric","Gregor"};
int examAssignments = 5;


int[] grades = new int[10];
string currentStudentLetterGrade = "";

Console.WriteLine("Student\t\tGrade \n");

foreach (string names in studentNames)
{
    //Console.WriteLine(names);
    string currentName = names;

    if (currentName == "Sophia")
        grades = sophiaScores;

    else if (currentName == "Andrew")
        grades = andrewScores;

    else if (currentName == "Emma")
        grades = emmaScores;

    else if (currentName == "Logan")
        grades = loganScores;
    else if (currentName == "Becky")
        grades = beckyScores;
    else if (currentName == "Chris")
        grades = chrisScores;
    else if (currentName == "Eric")
        grades = ericScores;
    else if (currentName == "Gregor")
        grades = gregorScores;
    else
        continue;

    int sumAssignmentScores = 0;
    decimal currentStudentGrade = 0;

    int gradedAssignments = 0;


    foreach (int score in grades)
    {
        gradedAssignments += 1;
        if (gradedAssignments <= examAssignments)
        {
            sumAssignmentScores += score;
        }
        else
        {
            sumAssignmentScores += score / 10;

        }

    }


    currentStudentGrade = (decimal)sumAssignmentScores / 5;

    /// aplicacion del grupo de califiacion en letra:
    /// 
    if (currentStudentGrade >= 97)
        currentStudentLetterGrade = "A+";
    else if (currentStudentGrade >= 93)
        currentStudentLetterGrade = "A";
    else if (currentStudentGrade >= 90)
        currentStudentLetterGrade = "A-";
    else if (currentStudentGrade >= 87)
        currentStudentLetterGrade = "B+";

    else if (currentStudentGrade >= 83)
        currentStudentLetterGrade = "B";

    else if (currentStudentGrade >= 80)
        currentStudentLetterGrade = "B-";

    else if (currentStudentGrade >= 77)
        currentStudentLetterGrade = "C+";

    else if (currentStudentGrade >= 73)
        currentStudentLetterGrade = "C";

    else if (currentStudentGrade >= 70)
        currentStudentLetterGrade = "C-";

    else if (currentStudentGrade >= 67)
        currentStudentLetterGrade = "D+";

    else if (currentStudentGrade >= 63)
        currentStudentLetterGrade = "D";

    else if (currentStudentGrade >= 60)
        currentStudentLetterGrade = "D-";

    else
        currentStudentLetterGrade = "F";



    Console.WriteLine($"{names}:\t\t" + currentStudentGrade + $"\t{currentStudentLetterGrade}");
>>>>>>> fd0185044edb065e598e1e69a49dd1332c2a7329


Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();










