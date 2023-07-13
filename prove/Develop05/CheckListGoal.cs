public class ChecklistGoal : Goal //Inherits attibutres from the Goal class
{
    public int TimesCompleted { get; set; }
    public int TargetTimes { get; set; }
    public int BonusPoints { get; set; }

    public ChecklistGoal(string name, int points, int targetTimes, int bonusPoints) : base(name, points)
    {
        TargetTimes = targetTimes;
        BonusPoints = bonusPoints;
        TimesCompleted = 0;
    }

    public override int Record() //Takes in account how many times a ask is completed and adds the points. 
    {
        TimesCompleted++;
        if (TimesCompleted == TargetTimes)
        {
            IsComplete = true;
            return Points + BonusPoints;
        }
        return Points;
    }
}
