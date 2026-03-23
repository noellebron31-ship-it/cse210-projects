using System;

public class word
{
    private string _text;
    private bool _isHidden;

    public word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide() => _isHidden = true;
    public bool IsHidden() => _isHidden;

    public string GetDisplayText()
    {
        if (_isHidden)
        {
            return new string('_', _text.Length);
        }
        else
        {
            return _text;
        }
    }
}