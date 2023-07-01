using System;
using System.Collections.Generic;
using System.IO;
class Journal 
{
    private List<Entry> entries = new List<Entry>(); //Private keeps entries from being changed or modified

    public void AddEntry(string prompt, string response)
    {
        Entry entry = new Entry(prompt, response); //Adds entry to entry list
        entries.Add(entry);
    }

    public void DisplayEntries()
    {
        foreach (Entry entry in entries) //Displays the entries
        {
            Console.WriteLine("Prompt: " + entry.Prompt);
            Console.WriteLine("Response: " + entry.Response);
            Console.WriteLine("Date: " + entry.Date);
            Console.WriteLine();
        }
    }

    public void SaveToFile(string filename) // saves files "github.com"
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in entries)
            {
                writer.WriteLine(entry.Prompt + "," + entry.Response + "," + entry.Date.ToString());
            }
        }
    }

    public void LoadFromFile(string filename) // Loads files github.com
    {
        using (StreamReader reader = new StreamReader(filename))
        {
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                string[] parts = line.Split(',');
                string prompt = parts[0];
                string response = parts[1];
                DateTime date = DateTime.Parse(parts[2]);
                Entry entry = new Entry(prompt, response, date);
                entries.Add(entry);
            }
        }
    }
}
   


