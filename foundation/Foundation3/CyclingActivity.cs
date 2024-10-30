public class CyclingActivity : Activity
{
    private double speed; // in mph

    public CyclingActivity(DateTime date, int minutes, double speed) : base(date, minutes)
    {
        this.speed = speed;
    }

    public override double GetDistance() => (speed * Minutes) / 60; // in miles

    public override double GetSpeed() => speed; // mph

    public override double GetPace() => 60 / speed; // min per mile

    protected override string GetActivityName() => "Cycling"; // Override to return "Cycling"

    public override string GetSummary()
    {
        return base.GetSummary() + $"- Distance: {GetDistance():0.0} miles, Speed: {GetSpeed():0.0} mph, Pace: {GetPace():0.0} min per mile";
    }
}
