using System;
using System.Collections.Generic;

// Represents a scripture by keeping its reference and individual Word objects.
public class Scripture
{
    // The reference that identifies the scripture passage.
    private Reference _reference;

    // Each Word object tracks its own text and hidden state.
    private List<Word> _words = new List<Word>();

    // Store the reference and create one Word object for every word in the text.
    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        foreach (string wordText in text.Split(' ', StringSplitOptions.RemoveEmptyEntries))
        {
            _words.Add(new Word(wordText));
        }
    }

    // Hide up to three randomly selected words that are still visible.
    public void HideRandomWords()
    {
        Random random = new Random();
        List<Word> availableWords = new List<Word>();

        // Build a temporary list so a word cannot be selected twice in one round
        // or selected again after it has already been hidden.
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                availableWords.Add(word);
            }
        }

        int numberToHide = 3;
        if (availableWords.Count < numberToHide)
        {
            // Hide all remaining words when fewer than three are still visible.
            numberToHide = availableWords.Count;
        }

        for (int i = 0; i < numberToHide; i++)
        {
            // Choose one visible word, hide it, and remove it from this round's choices.
            int randomIndex = random.Next(availableWords.Count);
            Word chosenWord = availableWords[randomIndex];

            chosenWord.Hide();
            availableWords.RemoveAt(randomIndex);
        }
    }

    // Return the formatted reference followed by the current display text of every word.
    public string GetDisplayText()
    {
        string displayText = _reference.GetDisplayText();

        foreach (Word word in _words)
        {
            displayText += " " + word.GetDisplayText();
        }

        return displayText;
    }

    // Return true only when every Word object reports that it is hidden.
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }

        return true;
    }
}
