public class RunningActivity : Activity
{
    private double distance; // in miles

    public RunningActivity(DateTime date, int minutes, double distance) : base(date, minutes)
    {
        this.distance = distance;
    }

    public override double GetDistance() => distance;

    public override double GetSpeed() => (distance / Minutes) * 60; // mph

    public override double GetPace() => Minutes / distance; // min per mile

    protected override string GetActivityName() => "Running"; // Override to return "Running"

    public override string GetSummary()
    {
        return base.GetSummary() + $"- Distance: {GetDistance():0.0} miles, Speed: {GetSpeed():0.0} mph, Pace: {GetPace():0.0} min per mile";
    }
}
