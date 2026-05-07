using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the grade percentage? ");
        string GradePercentage = Console.ReadLine();

        int grade = int.Parse(GradePercentage);
        String letter ="";
        
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
        Console.WriteLine($"Your grade is {letter}");

        if (grade >=  70)
        {
            Console.WriteLine("You Passed");
        }
        else
        {
            Console.WriteLine("ADD MORE EFFORT");
        }
    }
}