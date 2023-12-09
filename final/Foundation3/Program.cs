using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation3 World!");
        var eventAddress = new Address("19 Wanan St", "Pingdong", "Taiwan", "Taiwan");

        // Creating events of each type
        var lectureEvent = new Lectures("Tech Talk", "Learn about new technologies", DateTime.Now.AddDays(7), new TimeSpan(14, 30, 0), eventAddress, "John Smith", 50);

        var receptionEvent = new Receptions("rsvp@example.com", "Networking Night", "An evening of networking", DateTime.Now.AddDays(14), new TimeSpan(18, 0, 0), eventAddress);

        var outdoorEvent = new Outdoor("Weather permitting", "Summer Picnic", "Enjoy the outdoors", DateTime.Now.AddDays(21), new TimeSpan(12, 0, 0), eventAddress);

        // Displaying details for each event
        Console.WriteLine("Lecture Event:");
        Console.WriteLine($"{lectureEvent.GetStandardDetails()}\n");
        Console.WriteLine($"{lectureEvent.GetFullDetail()}\n");
        Console.WriteLine($"{lectureEvent.GetShortDescription()}\n");
        Console.WriteLine("========================\n");

        Console.WriteLine("Reception Event:");
        Console.WriteLine($"{receptionEvent.GetStandardDetails()}\n");
        Console.WriteLine($"{receptionEvent.GetFullDetail()}\n");
        Console.WriteLine($"{receptionEvent.GetShortDescription()}\n");
        Console.WriteLine("========================\n");

        Console.WriteLine("Outdoor Gathering Event:");
        Console.WriteLine($"{outdoorEvent.GetStandardDetails()}\n");
        Console.WriteLine($"{outdoorEvent.GetFullDetail()}\n");
        Console.WriteLine($"{outdoorEvent.GetShortDescription()}\n");
    }
}