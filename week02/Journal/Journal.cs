using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }
    
    public void DisplayEntries()
    {
        foreach (Entry entry in _entries)
        {
            entry.DisplayEntry();
        }
    }
    
    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                // Store the mood rating as the fourth field in each saved entry.
                writer.WriteLine($"{entry._date}|{entry._prompt}|{entry._text}|{entry._moodRating}");
            }
        }
    }

    public bool LoadFromFile(string filename)
    {
        try
        {
            using (StreamReader reader = new StreamReader(filename))
            {
                _entries.Clear();
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split('|');

                    // Older journal files have no fourth field for the mood rating.
                    int moodRating = 0;
                    if (parts.Length > 3)
                    {
                        int.TryParse(parts[3], out moodRating);
                    }

                    Entry entry = new Entry
                    {
                        _date = parts[0],
                        _prompt = parts[1],
                        _text = parts[2],
                        _moodRating = moodRating
                    };
                    _entries.Add(entry);
                }
            }

            return true;
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine($"Error, no se encontro el archivo {filename}");
            return false;
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine($"Error, no se encontro la carpeta del archivo {filename}");
            return false;
        }
    }
}
