using System;
using System.IO;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop02 World!"); //
        Journal journal = new Journal();
        Console.WriteLine("Welcome to Bernie's Journal program");
        List<string> choices = new List<string>
        {
            "1. Write",
            "2. Display",
            "3. load",
            "4. Save",
            "5. Quit"
        };
        int num;
        do
        {
            Console.WriteLine("Please select one of the following choices:");
            foreach (string choice in choices)
            {
                Console.WriteLine(choice);
            }
            Console.Write("What would you like to do? ");
            if (int.TryParse(Console.ReadLine(), out num))
            {
                if (num == 1) // Write with a random prompt
                {
                    string prompt = GeneratePrompt.Prompt();
                    Console.WriteLine(prompt);
                    string content = Console.ReadLine();
                    journal.AddEntry(DateTime.Now, prompt, content);
                    // break;  這功能為把這個while停止
                }
                else if (num == 2) // Display
                {
                    journal.DisplayEntries();
                    // break;
                }
                else if (num == 3) // Load
                {
                    if (File.Exists("journal.txt"))
                    {
                        journal.ReadFromFile("jounal.txt");
                        Console.WriteLine("File loaded successfully") ;
                        journal.DisplayEntries();
                    }
                    else 
                    {
                        Console.WriteLine("File does not find");
                    }
                    // break;
                }
                else if (num == 4) // Save
                {
                    journal.SaveToFile("journal.txt");
                    // break;
                }
                else if (num != 5)
                {
                    Console.WriteLine("Please enter number 1-5");
                }
            }
            else  
            {
                Console.WriteLine("Please enter with NUMBER");
            } 
        }
        while (num != 5);
        Console.WriteLine("See you next time ~");
    }
}