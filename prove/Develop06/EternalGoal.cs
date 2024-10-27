public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) 
        : base(name, description, points) { }

    public override void RecordEvent()
    {
        // This method can be empty or can increment some ongoing score if needed
    }

    public override bool IsComplete()
    {
        return false; // Eternal goals are never complete
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
