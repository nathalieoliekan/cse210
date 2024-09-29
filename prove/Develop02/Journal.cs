using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    //public void AddEntry(Entry newEntry)
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry); // Add "entry" to entries list

    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries) // for each entry in entries list - using Class Entry
        {
            entry.Display(); // Calls the display method on Entry
            Console.WriteLine(" ");
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries) // for each entry in entries list - using Class Entry
            {
                outputFile.WriteLine(entry); // Write entry to output file
            }
            
        }
    }

    public void LoadFromFile(string file)
    {
        string[] lines = System.IO.File.ReadAllLines(file);
        foreach (string line in lines)
        {

        }
    }

}