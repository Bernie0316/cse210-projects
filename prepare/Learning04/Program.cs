using System;
// Console.WriteLine("Hello Learning04 World!");

class Program
{
    static void Main(string[] args)
    {
        // Test your class by returning to the Main method in the Program.cs file. 
        // Create a simple assignment, call the method to get the summary, 
        // and then display it to the screen.
        Assignment assignment = new Assignment("Samuel Bennett", "Multiplication");
        // Console.WriteLine(assignment.GetSummary());
        string Name = assignment.GetSummary();
        Console.WriteLine(Name);
        
        MathAssignment mathAssignment = new MathAssignment("Roberto", "Fractions", "7.3", "8-19");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());

        WritingAssignment writingAssignment = new WritingAssignment("Marry Waters", "European History", "The Causes of World War II by Mary Waters");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}