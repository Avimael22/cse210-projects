using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Do you want to play a game? ");
        string answer = Console.ReadLine();
        while (answer == "yes"){
            Random RandomGenerator = new Random();
            int magicNumber = RandomGenerator.Next(1, 100);
            int guess;
            do {
                Console.WriteLine("What is your guess for the magic number? ");
                guess = int.Parse(Console.ReadLine());
                Console.WriteLine(" ");

                if (guess == magicNumber){
                Console.WriteLine("Congratulations! Your guess was correct!");
            }
                else if (guess > magicNumber){
                    Console.WriteLine("You should guess a little lower!");
                }
                else {
                    Console.WriteLine("You should guess a little higher");
                }
                
            } while(guess != magicNumber);
             
            Console.WriteLine("Do you want to continue playing? ");
            answer = Console.ReadLine();

        
        
        }  
    }
}