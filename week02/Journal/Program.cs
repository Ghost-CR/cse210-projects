using System;

// Enhancement: Each journal entry records a validated mood rating from 1 to 5
// so users can track how they felt when they wrote.

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        while(true)
        {
            Console.WriteLine("My Journal");
            Console.WriteLine("Choose one option");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            
            int option = int.Parse(Console.ReadLine());
            string filename;

            switch (option)
            {
                case 1:
                    Entry entry = new Entry();
                    entry._prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine(entry._prompt);
                    entry._date = DateTime.Today.ToString("MM/dd/yyyy");
                    Console.WriteLine("Write your response:");
                    entry._text = Console.ReadLine();

                    // Accept only a whole-number mood rating from 1 to 5.
                    Console.WriteLine("Rate your mood from 1 to 5:");
                    int moodRating = 0;
                    while (!int.TryParse(Console.ReadLine(), out moodRating) ||
                           moodRating < 1 || moodRating > 5)
                    {
                        Console.WriteLine("Invalid rating. Enter a whole number from 1 to 5:");
                    }
                    entry._moodRating = moodRating;

                    journal.AddEntry(entry);
                    Console.WriteLine("Entry added to the journal, but it is not saved to a file yet.");
                    Console.WriteLine("Choose 4 (Save) and enter a filename to save your changes.");
                    break;
                
                case 2:
                    journal.DisplayEntries();
                    break;

                case 3:
                    Console.WriteLine("Enter the Journal name");
                    filename = Console.ReadLine();
                    bool loaded = journal.LoadFromFile(filename);
                    if (loaded)
                    {
                        Console.WriteLine($"Loaded journal from '{filename}'.");
                        Console.WriteLine("To add entries, choose 1 (Write). Then choose 4 (Save) and enter this same filename.");
                        Console.WriteLine("Saving rewrites the file with all loaded and new entries.");
                    }
                    break;

                case 4:
                    Console.WriteLine("Enter Journal name");
                    filename = Console.ReadLine();
                    journal.SaveToFile(filename);
                    Console.WriteLine($"Journal saved to '{filename}'.");
                    break;
                
                case 5:
                    Console.WriteLine("Goodbye Traveler...");
                    return;
                default:
                    Console.WriteLine("Invalid option. Choose a number from 1 to 5.");
                    break;
            }
        }
    }
}
