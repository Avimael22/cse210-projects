using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.WriteLine("What was your grade percentage? ");
        string percentage = Console.ReadLine();

        int grade = int.Parse(percentage);
        string letter = null;
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
        else if (grade < 60)
        {
           letter = "F";
        }
        if (grade >= 70)
        {
            Console.WriteLine($"Congratulations You have passed the course");
        }
        else
        {
            Console.Write($"Sorry, You have failed the Course.  Dont let this discourage you and prepare even more for the retake");
        }

        Console.WriteLine($"Your letter grade is {letter}");


    }
}