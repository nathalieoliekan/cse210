public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) 
        : base(name, description, points) { }

    public override void RecordEvent()
    {
        
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"{(_points > 0 ? "[ ]" : "[ ]")} {_shortName} ({_description})";
    }

    public override string GetDetailsString()
    {
        return $"{(_points > 0 ? "[ ]" : "[ ]")} {_shortName} ({_description})";
    }
}
