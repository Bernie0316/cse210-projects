using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private string _referenceText;
    private List<Word> _words = new List<Word>();
    private HashSet<int> _hiddenIndices = new HashSet<int>();

    public Scripture(string referenceText, List<string> words)
    {
        _referenceText = referenceText;
        foreach (var word in words)
        {
            _words.Add(new Word(word));
        }
    }
    public void HideRandomWord()
    {
        Random random = new Random();
        int index;
        do 
        {
            index = random.Next(_words.Count);

        } while (_hiddenIndices.Contains(index));

        _words[index].Hide();
        _hiddenIndices.Add(index);
    }
    public string GetRenderedText()
    {
        string referenceText = _referenceText + " ";
        foreach (Word word in _words)
        {
            referenceText += word.GetRenderedText() + " ";
        }
        return referenceText;
    }
    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden);
    }
}

class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;
    public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }
    public string GetToString()
    {
        if (_verse == _endVerse)
        {
            return $"{_book} {_chapter}:{_verse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
    }
}

class Word
{
    private string _text;
    private bool _isHidden;
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }
    public void Hide()
    {
        _isHidden = true;
    }
    public void Show()
    {
        _isHidden = false;
    }
    public bool IsHidden
    {
        get { return _isHidden; }
    }
    public string GetRenderedText()
    {
        return _isHidden ? new string('_', _text.Length) : _text;
    }
}
