using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");
        List<string> menu = new List<string>
        {
            "1. start Bthing activity", 
            "2. Start Reflecting Activity",
            "3. Start Listing Activity",
            "4. Quit"
        };
        string num;
        do
        {
            Console.WriteLine("Menu Optioins:");
            foreach (string word in menu)
            {
                Console.WriteLine(word);
            } 
            Console.WriteLine("Select a chioce from the menu:");
            num = Console.ReadLine();
            Console.Clear();
            if (num == "1") // for Breathing Activity
            {
                BreathingActivity activity = new BreathingActivity();
                BreathingActivity.GetBreathinglist();
            }
            else if (num == "2") // for ReflectingActivity
            {
                ReflectingActivity activity = new ReflectingActivity();
                ReflectingActivity.GetReflectinglist();
            }
            else if (num == "3") // for ListingActivity
            {
                ListingActivity activity = new ListingActivity();
                ListingActivity.GetListinglist();
            }
        }
        while (num != "4");
    }
}