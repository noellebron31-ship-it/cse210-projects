using System;

public class scripture
{
    private reference _reference;
    private List<word> _words;

    public scripture(reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(w => new word(w)).ToList();
    }

    public void hiderandmwords(int numbertohide)
    {
        Random random = new Random();

        List<word> visibleWords = _words.Where(w => !w.IsHidden()).ToList();
        int actualtohide = Math.Min(numbertohide, visibleWords.Count);

        for (int i = 0; i < actualtohide; i++)
        {
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }

    public string GetDisplayText()
    {
        string text = string.Join(" ", _words.Select(w => w.GetDisplayText()));
        return $"{_reference.GetDisplayText()}: {text}";
    }

    public bool iscompletelyhidden()
    {
        return _words.All(w => w.IsHidden());
    }

}