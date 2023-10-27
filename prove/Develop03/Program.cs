using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> words = new List<string>
        {
            "Trust", "in", "the",  "Lord", "with", "with", "all", "thine", "heart", "and",
            "lean", "not", "unto", "thine", "own", "understanding;", 
            "in", "all", "thy", "ways", "ackonwledge", "him,", "and", 
            "he", "shall", "direct", "thy", "paths."
        };  
        Scripture scripture = new Scripture("Proverbs 3:5-6", words);
        Console.WriteLine($"Reference: {scripture.GetRenderedText()}");
        
        while (true)
        {
            Console.WriteLine("Press Enter to hide a random word.");
            // wait and感應user按下enter
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "quit")
            {
                break;
            }
            // 清除 上一個印出的東東
            Console.Clear();
            scripture.HideRandomWord();
            Console.WriteLine(scripture.GetRenderedText());
        }
    }
}