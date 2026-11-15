using System;
using System.Collections.Generic;

/*
Enhancements: Randomly select a scripture from a library containing passages
from the Bible and the Book of Mormon. Each round hides up to three visible
words, so words are not selected again after they have been hidden.
*/
class Program
{
    static void Main(string[] args)
    {
        // Keep scripture passages from both books in one library.
        List<Scripture> scriptureLibrary = new List<Scripture>
        {
            new Scripture(
                new Reference("Psalm", 23, 1, 2),
                "The Lord is my shepherd; I shall not want. " +
                "He maketh me to lie down in green pastures: he leadeth me beside the still waters."),
            new Scripture(
                new Reference("Philippians", 4, 13),
                "I can do all things through Christ which strengtheneth me."),
            new Scripture(
                new Reference("1 Nephi", 3, 7),
                "I will go and do the things which the Lord hath commanded."),
            new Scripture(
                new Reference("Alma", 37, 6, 7),
                // This excerpt includes a phrase from each of verses 6 and 7.
                "By small and simple things are great things brought to pass. " +
                "By very small means the Lord doth confound the wise.")
        };

        // Select one complete passage randomly for this practice session.
        Random random = new Random();
        int randomIndex = random.Next(scriptureLibrary.Count);
        Scripture scripture = scriptureLibrary[randomIndex];

        // Clear the console and show the complete scripture before the practice begins.
        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());

        // Continue until the user quits or every word has been hidden.
        while (!scripture.IsCompletelyHidden())
        {
            Console.WriteLine("Press Enter to hide words, or type 'quit' to finish.");
            string input = Console.ReadLine();

            // End the program if the input stream closes.
            if (input == null)
            {
                return;
            }

            // Ignore capitalization and accidental spaces around the command.
            input = input.Trim().ToLowerInvariant();

            if (input == "quit")
            {
                return;
            }

            // Only an empty line means Enter; ask again if other text was entered.
            if (input != "")
            {
                Console.WriteLine("Please press Enter or type 'quit'.");
                continue;
            }

            // Hide up to three visible words, then redraw the updated scripture.
            scripture.HideRandomWords();
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
        }
    }
}
