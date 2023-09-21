using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep5 World!");
        
        static void Main()
        {
            DisplayWelcome();
            string user_name =  PromptUserName();
            int user_num =  PromptUserNumber();
            int square_num = SquareNumber(user_num);
            DisplayResult(user_name, square_num);
        }
        
        
        // DisplayWelcome
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }
        
        // PromptUserName
        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }

        // PromptUserNumber
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int num = int.Parse(Console.ReadLine());
            return num;
        }

        // SquareNumber 
        static int SquareNumber(int num)
        {
            int square = num * num;
            return square;
        }

        // DisplayResult
        static void DisplayResult(string name, int square)
        {
            Console.WriteLine($"{name}, the square of your number is {square}");
        }

        Main();
        
    }
}