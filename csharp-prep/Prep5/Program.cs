using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayMessage();
        string name = PromptUserName();
        int number = PromptUserNumber();
        double square = SquareNumber(number);
        DisplayResult(name, square);

    }
    static void DisplayMessage(){
        Console.WriteLine("Welcome to the program!");
    }
    static string PromptUserName(){
        Console.WriteLine("What is your name? ");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber(){
        Console.WriteLine("What is your favorite number? ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }
    static double SquareNumber(int number){
        double numberSquared = Math.Pow(number, 2);
        return numberSquared;
    }
    static void DisplayResult(string name, double square){
        Console.WriteLine($"Brother {name}, the square of your number is {square}");
    }
}