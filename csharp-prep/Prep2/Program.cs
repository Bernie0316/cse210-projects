using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep2 World!");
        
        // 使用者輸入成績
        Console.Write("What is your grad percentage? ");
        string grad = Console.ReadLine();
        

        // 告訴電腦有數字
        int number = int.Parse(grad);

        // 成績變數
        string letter = "";

        //  if statement 判斷成績
        if (number >= 90)
        {
            if (number < 93)
            {
                letter = "A-";
            }
            else
            {
                letter = "A";
            }
        }
        else if (number >= 80)
        {
            if (number >= 87)
            {
                letter = "B+";
            }
            else if (number < 83)
            {
                letter = "B-";
            }
            else
            {
                letter = "B";
            }
        }
        else if (number >= 70)
        {
            if (number >= 77)
            {
                letter = "C+";
            }
            else if (number < 73)
            {
                letter = "C-";
            }
            else
            {
                letter = "C";
            }
        }
        else if (number >= 60)
        {
            if (number >= 67)
            {
                letter = "C+";
            }
            else if (number < 63)
            {
                letter = "C-";
            }
            else
            {
                letter = "C";
            }
        }
        else
        {
            letter = "F";
        }
        Console.WriteLine($"Your grad is: {letter}");
        //  if  分數判斷有無通過
        if (number >= 70)
        {
            Console.Write("You passed!");
        }
        else
        {
            Console.Write("You can be better next time!");
        }
    }
}