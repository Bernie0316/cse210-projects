using System;
public class Event
{
    private string _title;
    private string _description; 
    private DateTime _date; 
    private TimeSpan _time;
    private Address _address;
    public Event(string title, string description, DateTime date, TimeSpan time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }
    // method
    public string GetStandardDetails()
    {
        return $"Title: {_title}\nDescription: {_description}\nDate: {_date.ToShortDateString()}\nTime: {_time}\nAddress: {_address.GetAddress()}";
    }
    public string GetShortDescription()
    {   //type of event, title, and the date.
        return $"Type: {_title}\nTitle: {_title}\nDate: {_date.ToShortDateString()}"; 
    }
}
public class Lectures : Event //which have a "speaker" and have a limited "capacity".
{
    private string _speaker;
    private int _capacity;
    public Lectures(string title, string description, DateTime date, TimeSpan time, Address address, string speaker, int capacity) : base(title, description, date, time, address)
    { // Consructor
        _speaker = speaker;
        _capacity = capacity;

    }
    public string GetFullDetail()
    {   // method
        return $"{GetStandardDetails()}\nSpeaker: {_speaker}\nCapacity: {_capacity}";
    }
}
public class Receptions : Event // which require people to RSVP, or register, beforehand.
{
    private string _rsvpMail;
    public Receptions(string rsvpMail, string title, string description, DateTime date, TimeSpan time, Address address) : base(title, description, date, time, address)
    {
        _rsvpMail = rsvpMail;
    }
    public string GetFullDetail()
    {   // method
        return $"{GetStandardDetails()}\nRSVP Email: {_rsvpMail}";
    }
} 
public class Outdoor : Event
{   // gatherings, which do not have a limit on attendees, but need to track the weather forecast.
    private string _weather;
    public Outdoor(string weather, string title, string description, DateTime date, TimeSpan time, Address address) : base(title, description, date, time, address)
    {
        _weather = weather;
    }
    public string GetFullDetail()
    {   // method
        return $"{GetStandardDetails()}\nWeather: {_weather}";
    }
} 
public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public string GetAddress()
    {
        return $"{_street}, {_city}, {_state}, {_country}";
    }
}