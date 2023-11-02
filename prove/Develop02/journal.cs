using System.IO;
using System.Text.Json;
using System.Text.Json.Nodes;

public class Journal
{
    private PromptGenerator _promptGenerator;
    public List<Entry> _entries;
    public string _fileName;

    public Journal() 
    {
        this._entries = new List<Entry>();
        //this.PopulatePrompts();
        this._fileName = "journal.json";
        this._promptGenerator = new PromptGenerator();
    }

    public void SaveEntry(Entry entry)
    {
        this._entries.Add(entry);
    }

    public void Write()
    {
        string prompt = this._promptGenerator.GetRandomPrompt();
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