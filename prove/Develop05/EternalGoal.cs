public class EternalGoal : Goal //Gains inheritense form the goal class 
{
    public EternalGoal(string name, int points) : base(name, points) { }

    public override int Record()
    {
        return Points;
    }
}
