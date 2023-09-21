using System;
using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Runtime.Serialization;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep3 World!");
        // part1
        // Console.Write ("What is the magic number? ");
        // int number = int.Parse(Console.ReadLine());
        // part 3
        Random randomGenrator = new Random();
        int number = randomGenrator.Next(1,100);

        Console.Write ("What is your guess? ");
        int guess = int.Parse(Console.ReadLine());
        
        // SC 1
        int times = 1;      

        // part 2
        while (guess != number)
        {
            if (guess > number)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < number)
            {
                Console.WriteLine("Higher");
            }
            Console.Write ("What is your guess? ");
            times += 1;
            guess = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("You guessed it!");
        Console.WriteLine($"It took you {times} times to guess it.");
        
        // sc 2
        Console.Write("Wonna play again?");
        string again = Console.ReadLine();
        if (again == "Yes")
        {
            // I'm still fig.. out how can I let the program run again...
        }
        else
        {
            Console.Write("See you next time!");
        }
    }
}