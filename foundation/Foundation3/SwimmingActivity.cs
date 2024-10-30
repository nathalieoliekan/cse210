public class SwimmingActivity : Activity
{
    private int laps;

    public SwimmingActivity(DateTime date, int minutes, int laps) : base(date, minutes)
    {
        this.laps = laps;
    }

    public override double GetDistance() => (laps * 50) / 1000.0; // in km

    public override double GetSpeed() => (GetDistance() / Minutes) * 60; // kph

    public override double GetPace() => Minutes / GetDistance(); // min per km

    protected override string GetActivityName() => "Swimming"; // Override to return "Swimming"

    public override string GetSummary()
    {
        // Calculate the distance in miles for the summary
        double distanceInMiles = GetDistance() * 0.621371; // Convert km to miles
        return base.GetSummary() + $"- Laps: {laps}, Distance: {distanceInMiles:0.0} miles, Speed: {GetSpeed():0.0} kph, Pace: {GetPace():0.0} min per km";
    }
}
