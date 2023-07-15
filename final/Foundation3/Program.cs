using System;
using System.Collections.Generic;
using System.Text;

public class Program
{
    public static void Main()
    {
        // Create some sample events
        var lecture = new Lecture(
            "Introduction to C#",
            "Learn the basics of C# programming",
            new DateTime(2023, 7, 15),
            new TimeSpan(14, 0, 0),
            new Address("123 Main St", "Rexburg", "ID", "USA"),
            "John Doe",
            100
        );

        var reception = new Reception(
            "Meet and Greet",
            "Network with other professionals",
            new DateTime(2023, 7, 16),
            new TimeSpan(18, 0, 0),
            new Address("456 Elm St", "Rexburg", "ID", "USA"),
            "rsvp@example.com"
        );

        var outdoorGathering = new OutdoorGathering(
            "Picnic in the Park",
            "Enjoy food and games in the great outdoors",
            new DateTime(2023, 7, 17),
            new TimeSpan(12, 0, 0),
            new Address("789 Oak St", "Rexburg", "ID", "USA"),
            "Sunny and warm"
        );

        // Add the events to a list
        List<Event> events = new List<Event>();
        events.Add(lecture);
        events.Add(reception);
        events.Add(outdoorGathering);

        // Display information about each event
        foreach (Event eventObj in events)
        {
            Console.WriteLine(eventObj.GetStandardDetails());
            Console.WriteLine();
            Console.WriteLine(eventObj.GetFullDetails());
            Console.WriteLine();
            Console.WriteLine(eventObj.GetShortDescription());
            Console.WriteLine();
        }
    }
}

public abstract class Event
{
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime Date { get; set; }
    public TimeSpan Time { get; set; }
    public Address Address { get; set; }

    public Event(string title, string description, DateTime date, TimeSpan time, Address address)
    {
        Title = title;
        Description = description;
        Date = date;
        Time = time;
        Address = address;
    }

    public virtual string GetStandardDetails()
    {
        return $"{Title}\n{Description}\n{Date.ToShortDateString()} {Time}\n{Address}";
    }

    public abstract string GetFullDetails();

    public virtual string GetShortDescription()
    {
        return $"{GetType().Name}: {Title} on {Date.ToShortDateString()}";
    }
}

public class Lecture : Event
{
    public string Speaker { get; set; }
    public int Capacity { get; set; }

    public Lecture(string title, string description, DateTime date, TimeSpan time, Address address, string speaker, int capacity)
        : base(title, description, date, time, address)
    {
        Speaker = speaker;
        Capacity = capacity;
    }

    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nSpeaker: {Speaker}\nCapacity: {Capacity}";
    }
}

public class OutdoorGathering : Event
{
    public string WeatherForecast { get; set; }

    public OutdoorGathering(string title, string description, DateTime date, TimeSpan time, Address address, string weatherForecast)
        : base(title, description, date, time, address)
    {
        WeatherForecast = weatherForecast;
    }

    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nWeather forecast: {WeatherForecast}";
    }
}


public class Reception : Event
{
    public string RsvpEmail { get; set; }

    public Reception(string title, string description, DateTime date, TimeSpan time, Address address, string rsvpEmail)
        : base(title, description, date, time, address)
    {
        RsvpEmail = rsvpEmail;
    }

    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nRSVP to: {RsvpEmail}";
    }

}
