public class Word
{
    private string _word;
    private bool _hidden;

    public Word(string word)
    {
        _word = word;
        _hidden = false;
    }
    public void Hide()
    {
        _hidden = true;
    }

    public void Show()
    {
        _hidden = false;
    }

    public bool IsHidden()
    {
        return _hidden;
    }
    public string GetRenderedText()
    {
        if (_hidden == true)
        {
            return new String('_', _word.Length);
        }

        return _word;
    }
}