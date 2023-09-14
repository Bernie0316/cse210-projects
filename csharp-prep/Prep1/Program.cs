using System;

class Program
{
    static void Main(string[] args)
    {
        // writeline = 印完之後換行
        // Console.WriteLine("Hello Prep1 World!");
        
        // = python input
        Console.Write("What is your first name? ");
        string firstname = Console.ReadLine();
        Console.Write("What is your last name? ");
        string lastname = Console.ReadLine();
        
        // = python f string print out
        Console.WriteLine($"\nYour name is {lastname}, {firstname} {lastname}.");

    }
}
// 程式碼需要打在上面的 program 裏面
// Console.Write("What is your first name?");
// string firstname = Console.Write();