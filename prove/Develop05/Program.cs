using System;
using System.Collections.Generic;


public class Program
{
    static void Main(string[] args)
    {
        List<Goal> goals = new List<Goal>(); //default points and goals
        goals.Add(new SimpleGoal("Run a marathon", 1000));
        goals.Add(new EternalGoal("Read scriptures", 100));
        goals.Add(new ChecklistGoal("Attend temple", 50, 10, 500));

        int score = 0;

        while (true)
        {
            Console.WriteLine("Current score: " + score); //Adds the points 
            Console.WriteLine("Goals:");
            foreach (var goal in goals)
            {
                string status = goal.IsComplete ? "[X]" : "[ ]"; //Marks the "X's when complete"
                if (goal is ChecklistGoal checklistGoal)
                {
                    status += " Completed " + checklistGoal.TimesCompleted + "/" + checklistGoal.TargetTimes + " times";
                }
                Console.WriteLine(status + " " + goal.Name);
            }

            Console.WriteLine("Enter a goal to record or type 'new' to create a new goal:"); // Asks user to create a goal
            string input = Console.ReadLine();
            if (input == "new")
            {
                Console.WriteLine("Enter goal name:"); // Enters goal
                string name = Console.ReadLine();
                Console.WriteLine("Enter goal type (simple, eternal, checklist):");
                string type = Console.ReadLine();
                Console.WriteLine("Enter goal points:");
                int points = int.Parse(Console.ReadLine());
                if (type == "simple") //Checks to see if the goal is simple
                {
                    goals.Add(new SimpleGoal(name, points));
                }
                else if (type == "eternal") //Checks if user entered in an eternal goal
                {
                    goals.Add(new EternalGoal(name, points));
                }
                else if (type == "checklist") // Checks to see if the goal is a checklist
                {
                    Console.WriteLine("Enter target times:"); //Checks to see how many times for the checklist.
                    int targetTimes = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter bonus points:"); // Lets the user assign point values
                    int bonusPoints = int.Parse(Console.ReadLine());
                    goals.Add(new ChecklistGoal(name, points, targetTimes, bonusPoints));
                }
            }
            else
            {
                foreach (var goal in goals)
                {
                    if (goal.Name == input)
                    {
                        score += goal.Record();
                        break;
                    }
                }
            }
        }
    }
}
