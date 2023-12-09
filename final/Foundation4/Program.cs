using System;

class Program
{
    static void Main(string[] args)
    {
        Running running = new Running(date: DateTime.Now, duration: 30, activity: "Running", data: 8);
        Bicycles bicycles = new Bicycles(date: DateTime.Now, duration: 45, activity: "Bicycles", data: 30);
        Swimming swimming = new Swimming(date: DateTime.Now, duration: 60, activity: "Swimming", data: 10);

        List<Activity> activities = new List<Activity>
        {
            running,
            bicycles,
            swimming
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}