using System;
using System.Collections.Generic;
using static Cycling;

public class Program
{
    public static void Main()
    {
        // Create some sample activities
        var running = new Running(
            new DateTime(2023, 11, 3),
            30,
            3.0
        );

        var cycling = new Cycling(
            new DateTime(2023, 11, 4),
            45,
            15.0
        );

        var swimming = new Swimming(
            new DateTime(2023, 11, 5),
            60,
            40
        );

        // Add the activities to a list
        List<Activity> activities = new List<Activity>();
        activities.Add(running);
        activities.Add(cycling);
        activities.Add(swimming);

        // Display summary information about each activity
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}

public abstract class Activity
{
    public DateTime Date { get; set; }
    public int Minutes { get; set; }

    public Activity(DateTime date, int minutes)
    {
        Date = date;
        Minutes = minutes;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{Date.ToString("dd MMM yyyy")} {GetType().Name} ({Minutes} min) - Distance: {GetDistance():0.0} miles, Speed: {GetSpeed():0.0} mph, Pace: {GetPace():0.0} min per mile";
    }
}

public class Running : Activity
{
    public double Distance { get; set; }

    public Running(DateTime date, int minutes, double distance)
        : base(date, minutes)
    {
        Distance = distance;
    }

    public override double GetDistance()
    {
        return Distance;
    }

    public override double GetSpeed()
    {
        return (Distance / Minutes) * 60;
    }

    public override double GetPace()
    {
        return Minutes / Distance;
    }
}

public class Cycling : Activity
{
    public double Speed { get; set; }

    public Cycling(DateTime date, int minutes, double speed)
        : base(date, minutes)
    {
        Speed = speed;
    }

    public override double GetDistance()
    {
        return (Speed / 60) * Minutes;
    }

    public override double GetSpeed()
    {
        return Speed;
    }

    public override double GetPace()
    {
        return 60 / Speed;
    }

 
    public class Swimming : Activity
    {
        public int Laps { get; set; }

        public Swimming(DateTime date, int minutes, int laps)
            : base(date, minutes)
        {
            Laps = laps;
        }

        public override double GetDistance()
        {
            return (Laps * 50.0) / 1609.34; // Convert meters to miles
        }

        public override double GetSpeed()
        {
            return (GetDistance() / Minutes) * 60;
        }

        public override double GetPace()
        {
            return Minutes / GetDistance();
        }

        
    }
}