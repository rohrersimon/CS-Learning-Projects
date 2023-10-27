using System;
using System.Runtime.InteropServices;

public class Course2
{
    /*
    Program that takes student names and their 5 scores. It calculates
    their overall score and letter grade, and then prints the results
    to the console.
    */
    public static void Module5()
    {
        // Initialise variables
        int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
        int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
        int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
        int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };
        int[] beckyScores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
        int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
        int[] ericScores = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
        int[] gregorScores = new int[] { 91, 91, 91, 91, 91, 91, 91 };    

        // Student names
        string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };       
        
        int[] studentScores = new int[] { 1, 1, 1, 1, 1 };
        decimal studentScoreSum = 0m;
        decimal studentScore = 0m;
        int amountExtraCreditScores = 0;
        string studentLetterGrade = "Z";
        int amountRegularScores = 5;

        //Calculations and print to console
        Console.WriteLine("Student\t\tGrade\n");

        foreach (string name in studentNames)
        {
            //reset variable
            studentScoreSum = 0;
            
            if (name == "Sophia")
            {
                studentScores = sophiaScores;
            }
            else if (name == "Andrew")
            {
                studentScores = andrewScores;
            }
            else if (name == "Emma")
            {
                studentScores = emmaScores;
            }
            else if (name == "Logan")
            {
                studentScores = loganScores;
            }
            else if (name == "Becky")
                studentScores = beckyScores;
            else if (name == "Chris")
                studentScores = chrisScores;
            else if (name == "Eric")
                studentScores = ericScores;
            else if (name == "Gregor")
                studentScores = gregorScores;
            else
                continue;

            for (int i = amountRegularScores; i >= 1; i--)
            {
                studentScoreSum += studentScores[(i - 1)];
            }

            if (studentScores.Length > amountRegularScores)
            {
                amountExtraCreditScores = studentScores.Length - amountRegularScores;
                for (int i = amountExtraCreditScores; i > 0; i--)
                {
                    studentScoreSum += (studentScores[(4 + i)]/10);
                }
            }

            studentScore = studentScoreSum/amountRegularScores;

            studentLetterGrade = GetLetterGrade(studentScore);

            Console.WriteLine($"{name}:\t\t{studentScore}\t{studentLetterGrade}");
        }

        Console.WriteLine();
        Console.WriteLine("Press the Enter key to continue");
        Console.ReadLine();
    }

    /*
    This method's argument is the number grade and returns
    the corresponding letter grade.
    */
    public static string GetLetterGrade(decimal grade)
    {
        string[] letterGrades = { "A+", "A", "A-", "B+", "B", "B-", "C+", "C", "C-", "D+", "D", "D-", "F" };

        if (grade >= 97)
        {
            return letterGrades[0];
        }
        else if (grade >= 93)
        {
            return letterGrades[1];
        }
        else if (grade >= 90)
        {
            return letterGrades[2];
        }
        else if (grade >= 87)
        {
            return letterGrades[3];
        }
        else if (grade >= 83)
        {
            return letterGrades[4];
        }
        else if (grade >= 80)
        {
            return letterGrades[5];
        }
        else if (grade >= 77)
        {
            return letterGrades[6];
        }
        else if (grade >= 73)
        {
            return letterGrades[7];
        }
        else if (grade >= 70)
        {
            return letterGrades[8];
        }
        else if (grade >= 67)
        {
            return letterGrades[9];
        }
        else if (grade >= 63)
        {
            return letterGrades[10];
        }
        else if (grade >= 60)
        {
            return letterGrades[11];
        }
        else
        {
            return letterGrades[12];
        }
    }
}