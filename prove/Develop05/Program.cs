using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> options = new List<string>
        {
            "\nMenu Options",
            " 1. Creat New Goal",
            " 2. List Goals",
            " 3. Save Goals",
            " 4. Load Goals",
            " 5. Record Event\n",
        };
        List<string> types = new List<string>
        {
            "The Types of Goals are:",
            " 1. Simple Goal",
            " 2. Eternal Goal",
            " 3. Checklist Goal"
        };
        List<string> goalinputs = new List<string>
        {
            "Whitch types of the goal would you like to create? ",
            "What is the name of your goao? ",
            "What is a short description of it? "
        };
        string num;
        do
        {
            Console.WriteLine("\nYou have 0 points");
            foreach (string option in options)
            {
                Console.WriteLine($"  {option}");
            }
            Console.Write("Select a choic form the menu: ");
            num = Console.ReadLine();
            if (num == "1")
            {
                foreach (string type in types)
                {
                    Console.WriteLine(type);
                }
                foreach (string goalinput in goalinputs)
                {
                    Console.WriteLine(goalinput);
                    Console.Read();
                }
            }
            if (num == "2")
            {
                Console.WriteLine("2");
            }
            if (num == "3")
            {
                Console.WriteLine("3");
            }
            if (num == "4")
            {
                Console.WriteLine("4");
            }
        } while (num != "5");
    }
}