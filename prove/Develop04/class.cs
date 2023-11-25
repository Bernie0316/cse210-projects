using System;
Random random = new Random();
public class Activity
{
    // attributes
    private string _activityName;
    private string _description;
    private int _durationInSeconds;
    // construtor
    public Activity(string activityName, string description, int durationInSeconds)
    {
        _activityName = activityName;
        _description = description;
        _durationInSeconds = durationInSeconds;
    }
    // behavior
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"wellcome to the {_name} activity\n")
        Console.WriteLine(_description)
        Console.WriteLine("\nHow long, in seconds, would you like for your session?")
        _durationInSeconds = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get ready...")
        ShowingASpinner();
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!!");
        ShowingASpinner();
        Console.WriteLine($"You have comepleted another {_durationInSeconds} seconds of the {_name} activity.");
        ShowingASpinner();
    }
    public void ShowingASpinner()
    {
        List<string> animation = new List<string>
        {
            "|", "/", "-", "\\", '|', '/', "-", "\\"
        }
        foreach (string s in animation)
        {
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
    public void ShowingACountdownTimer()
    {
        for (int i = 5; i > 0; i--);
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b") // "\b" 代表印出的文字編輯線往回一格
        }
    }
}
public class BreathingActivity : Activity
{
    // attributes
    private List<string> _prompts = new List<string>
    {
        "\n\nBreath in...", "\nNow breath out..."
    }
    // constructor
    public BreathingActivity(string activityName, string description, int durationInSeconds, List<string> prompts) : base (activityName, description, durationInSeconds)
    {
        _name = "Breathing";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
        _durationInSeconds = durationInSeconds;
        _prompts = List<string> _prompts;
    }
    public void GetBreathinglist() // method 
    {
        DisplayStartingMessage();
        // display the prompts for the Breathing Actovoty and timer
        foreach (string prompt in prompts)
        {
            Console.Write(prompt)
            for (int i = 5; i > 0; i--)
            { // show出呼吸倒數
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b") // "\b" 代表印出的文字編輯線往回一格
            }
        }
        DisplayEndingMessage();
    }
} 
public class ReflectingActivity : Activity
{
    // atrributes
    private List<string> prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    } 
    private List<string> questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    }
    // constructor
    public ReflectingActivity(string activityName, string description, int durationInSeconds, List<string> prompts, List<string> questions) : base (activityName, description, durationInSeconds)
    {
        _name = "Reflecting";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        _durationInSeconds = durationInSeconds;
        _prompts = prompts;
        _questions = questions;
    } 
    public void GetReflectinglist()
    {
        DisplayStartingMessage();
        // Timer will stop till the user pressed enter
        
        Console.WriteLine("\nConsider the following prompt:\n")
        int randomIndex = random.Next(_prompts.Count);
        string randomPrompt = _prompts[randomIndex];
        Console.WriteLine($" ---{randomPrompt}---") // randomly show a prompt
        Console.WriteLine("\nWhen you have some mind, press enter to Continue.")
        Console.WriteLine(); // wait for user's enter
        Console.WriteLine("Now ponder on each of the following questions as they ralated to this experience.")
        Console.Write("You may begin in: ")
        ShowingACountdownTimer();
        Console.Clear();
        
        int randomIndex = random.Next(_questions.Count);
        string randomQuestion = _questions[randomIndex];
        Console.WriteLine($" ---{randomQuestion}---")
        ShowingASpinner();
    
        DisplayEndingMessage();
    }  
}
public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    }
    private List<string> _userInputs = new List<string>();
    // constructor
    public ListingActivity(string activityName, string description, int durationInSeconds, List<string> prompts, List<string> userInputs) : base (activityName, description, durationInSeconds)
    {
        _name = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        durationInSeconds = durationInSeconds;
        _prompt = prompts;
        _userInputs = userInputs;
    }
    
    public void GetListinglist() 
    {
        DisplayStartingMessage();
        
        Console.WriteLine("List is many responses you can to the following prompt:");
        int randomIndex = random.Next(_prompts.Count);
        string randomPrompt = _prompts[randomIndex];
        Console.WriteLine($" ---{randomPrompt}---")
        Console.Write("You may begin in: ")
        ShowingACountdownTimer();
        _userInputs =  Console.ReadLine("> "); // user type in 

        DisplayEndingMessage();
    }
}