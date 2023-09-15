using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!");
        Console.Write("Please enter your first name: ");
         string first_name = Console.ReadLine();
        Console.Write("Please enter your last name: ");
         string last_name = Console.ReadLine();
        Console.WriteLine($"Your name is {first_name}, {first_name} {last_name}.");
    }
}