using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter a series of numbers, enter 0 when finished");
        int number = 1;
        List<int>numbersArray = new List<int>();
        do {
            Console.WriteLine("Enter a number");
            number = int.Parse(Console.ReadLine());
            numbersArray.Add(number);
        } while(number != 0);
        int maxNumber = 1;
        int sum = 0;
        foreach (int num in numbersArray){
            if (num > maxNumber){
                maxNumber = num;
            }
            else {
                continue;
            }
        }
        foreach (int num in numbersArray){
            sum += num;
        }
        float average = sum/(numbersArray.Count - 1);
        Console.WriteLine($"The sume of the numbers is: {sum}");
        Console.WriteLine($"The largest number is: {maxNumber}");
        Console.WriteLine($"The average of the numbers is: {average}");
    }
}