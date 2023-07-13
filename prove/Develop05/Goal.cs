public abstract class Goal
{
    public string Name { get; set; } //Gets name for the goals entered 
    public int Points { get; set; } //Gets the point values 
    public bool IsComplete { get; set; } //Checks to see if the tasks are complete

    public Goal(string name, int points)
    {
        Name = name;
        Points = points;
        IsComplete = false;
    }

    public abstract int Record(); //Stores all the goal imformation hear 
}
