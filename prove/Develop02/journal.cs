using System.IO;
using System.Text.Json;
using System.Text.Json.Nodes;

public class Journal
{
    public List<Entry> _entries;
    public List<string> _prompts;
    public string _fileName;

    public Journal() 
    {
        this._entries = new List<Entry>();
        this.PopulatePrompts();
        this._fileName = "journal.json";
    }

    public void PopulatePrompts()
    {
        this._prompts = new List<string>();
        this._prompts.Add("Who was the most interesting person I interacted with today?");
        this._prompts.Add("What was the best part of my day?");
        this._prompts.Add("What did you accomplish that you are most proud of today?");
        this._prompts.Add("What was the strongest emotion I felt today?");
        this._prompts.Add("If I had one thing I could do over today, what would it be?");
        this._prompts.Add("How did you help someone today?");
    }

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int ndx = rand.Next(this._prompts.Count);
        return this._prompts[ndx];
    }

    public void SaveEntry(Entry entry)
    {
        this._entries.Add(entry);
    }

    public void Write()
    {
        string prompt = this.GetRandomPrompt();
        Console.WriteLine(prompt);
        string entryText = Console.ReadLine();
        Entry newEntry = new Entry() {_prompt = prompt, _text = entryText, _date = DateTime.Now.ToString()};
        this._entries.Add(newEntry);
    }

    public void Display()
    {
        foreach (Entry e in this._entries)
        {
            Console.WriteLine(e.ToString() + "\n");
        }
    }

    public void Load()
    {
        string text = File.ReadAllText(this._fileName);
        this._entries = JsonSerializer.Deserialize<List<Entry>>(text);

        Console.WriteLine("Journal loaded successfully...");
    }

    public void Save()
    {
        string json = JsonSerializer.Serialize(this._entries);
        File.WriteAllText(this._fileName, json);

        Console.WriteLine("Journal saved successfully...");
    }
}