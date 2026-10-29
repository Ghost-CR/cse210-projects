using System;

class Program
{
    static void Main(string[] args)
    {
        /// User input for grade percentage
        Console.WriteLine("Type your grade percentage: ");
        string input = Console.ReadLine();
        /// Convert the input to a float
        float grade = float.Parse(input);
        /// get letter grade from the GetLetterGrade method
        string letterGrade = GetLetterGrade(grade);
        /// get letter sign from the GetLetterSign method
        string sign = GetLetterSign(grade, letterGrade);
        if (letterGrade != "F")
        {
            string finalgrade = letterGrade + sign;
            Console.WriteLine($"Your grade is: {finalgrade}");
        }
        else
        {
            Console.WriteLine($"Your grade is: {letterGrade}");
        }
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class!");
        }
        else
        {
            Console.WriteLine("Sorry, you did not pass the class.");
        }

    }

    static string GetLetterGrade(float grade)
    {
        string letterGrade = "F";
        if (grade >= 90)
        {
        letterGrade = "A";
        }
        if (grade >= 80 && grade < 90)
        {
            letterGrade = "B";
        }
        if (grade >= 70 && grade < 80)
        {
            letterGrade = "C";
        }
        if (grade >= 60 && grade < 70)
        {
            letterGrade = "D";
        }
        if (grade < 60)
        {
            letterGrade = "F";
        }
        return letterGrade;
    }
    static string GetLetterSign(float grade, string letterGrade)
    {
        string sign = "";
        if (letterGrade == "A" && grade < 93)
        {
            sign = "-";
        }
        else if (letterGrade == "B" || letterGrade == "C" || letterGrade == "D")
        {
            if (grade % 10 >= 7)
            {
                sign = "+";
            }
            else if (grade % 10 < 3)
            {
                sign = "-";
            }
        }
        return sign;
    }
    
}