using System;
using System.IO;
using System.Collections.Generic;

public class GeneratePrompt
{
    public static string Prompt()
    {
        List<string> prompts = new List<string>
        {
            "Document your experiences and personal growth in school, work, or life in general.",
            "List things and people you're grateful for and moments of happiness.",
            "Write essays or poetry reflecting your thoughts, emotions, and creativity.",
            "Explore your expectations, plans, and aspirations for the future.",
            "Express your thoughts and reflections on social issues, news events, or political matters."
        };
        // 開始使用Random
        Random random = new Random();
        int index = random.Next(0, prompts.Count);
        string sentence = prompts[index];
        return sentence;
    }
}

public class Journal
{
    public List<Entry> entries;
    public Journal()
    {
        entries = new List<Entry>();
    } 
    public void AddEntry(DateTime date, string prompt, string content)
    {
        entries.Add(new Entry(date, prompt, content));
    }
    public void DisplayEntries()
    {
        foreach (Entry entry in entries)
        {
            entry.Display();
        }
    }
    public void SaveToFile(string filename)
    {
        Console.WriteLine("Saving to file...");
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in entries)
            {
                outputFile.WriteLine($"{entry._Date},{entry._Prompt},{entry._Content}");
            }
        }
        Console.WriteLine("File saved successfully.");
    }
 
    public void ReadFromFile(string filename)
    {
        string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, filename);
        if (File.Exists(filename))
        {
            string[] lines = File.ReadAllLines(filename);
    
            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                if (parts.Length == 3)
                {
                    if (DateTime.TryParse(parts[0], out DateTime dateOfGile))
                    {
                        DateTime dateOfFile = DateTime.Parse(parts[0]);
                        string promptOfFile = parts[1];
                        string contentOfFile = parts[2];
                        entries.Add(new Entry(dateOfFile, promptOfFile, contentOfFile));
                    }
                    else
                    {
                        Console.WriteLine($"There's some error : {parts[0]}");
                    }
                }
            }
        }
        else
        {
            Console.WriteLine("Can't Find The File.");
        }
    }
}


public class Entry
{
    public DateTime _Date;
    public string _Prompt;
    public string _Content;
 
    public Entry(DateTime date, string prompt, string content)
    {
        _Date = date;
        _Prompt = prompt;
        _Content = content;
    }
 
    public void Display()
    {
        Console.WriteLine($"Date: {_Date.ToShortDateString()} - Prompt: {_Prompt}");
        Console.WriteLine($"{_Content}");
    }
}