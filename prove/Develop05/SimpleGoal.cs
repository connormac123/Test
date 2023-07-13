
public class SimpleGoal : Goal //Gains inheritense form the goal class
{
    public SimpleGoal(string name, int points) : base(name, points) { }

    public override int Record()
    {
        IsComplete = true; //Checks to see if goal is complete
        return Points; //Returns points 
    }
}
