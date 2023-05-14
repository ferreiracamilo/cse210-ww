public abstract class Goal{
    
    protected string _name;
    protected string _description;
    protected int _rewardPoints;
    protected int _completionCount;

    public abstract void SaveGoal();

    public abstract void RecordEvent();

    public abstract int CalculatePoints();

}