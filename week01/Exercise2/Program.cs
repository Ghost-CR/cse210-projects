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
        string letter = GetLetterGrade(grade);
        /// get letter sign from the GetLetterSign method
        string sign = GetLetterSign(grade, letter);
        string finalGrade = letter + sign;
        Console.WriteLine($"Your grade is: {finalGrade}");
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
        string letter;
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        return letter;
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
