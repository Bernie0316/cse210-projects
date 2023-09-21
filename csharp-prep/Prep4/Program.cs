using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep4 World!");
        List<int> numbers;
        numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int num = int.Parse(Console.ReadLine());
        
        while (num != 0)
        {
            numbers.Add(num);
            Console.Write("Enter number: ");
            num = int.Parse(Console.ReadLine());
        }
        // sum the list numbers
        int total = 0;
        foreach (int number in numbers)
        {
            total += number;
        }
        Console.WriteLine($"The sum is {total}");

        // average the list numbers
        int len = numbers.Count();
        Console.WriteLine(len);
        float average = ((float)total) / len;
        Console.WriteLine($"The average is {average}");

        // find the largest number
        int largest = numbers[0];
        foreach (int number in numbers)
        {
            if (number > largest)
            {
                largest = number;
            }
        }
        Console.WriteLine($"The largest number is {largest}");

        // sc 1
        //  find the smallest positive number (the positive number that is closest to zero).
        
        // sc 2
        // 把數列由小至大重新排列印出
    }
}