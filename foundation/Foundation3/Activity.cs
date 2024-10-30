public abstract class Activity
{
    protected DateTime Date { get; set; }
    protected int Minutes { get; set; }

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
        // Use a simple switch case to map class names to activity names
        string activityName = GetActivityName();
        return $"{Date:dd MMM yyyy} {activityName} ({Minutes} min)";
    }

    protected abstract string GetActivityName(); // New method for getting activity name
}
